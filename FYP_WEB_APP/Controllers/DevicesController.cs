﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using MongoDB.Bson;
using FYP_APP.Models.MongoModels;
using FYP_WEB_APP.Controllers.Mongodb;
using FYP_WEB_APP.Models.MongoModels;
using FYP_WEB_APP.Models;
using System;
using System.Diagnostics;
using FYP_WEB_APP.Controllers;

namespace FYP_APP.Controllers
{
	public class DevicesController : Controller
	{
		public List<DevicesListModel> MongoDevicesList = new List<DevicesListModel> { };
		public IMongoCollection<DevicesListModel> Getconn()
		{
			ConnectDB conn = new ConnectDB();
			var database = conn.Conn();
			var collection = database.GetCollection<DevicesListModel>("DEVICES_LIST");
			return collection;
		}
		[Route("Devices/Devices")]
		public IActionResult Devices()
		{
			ViewBag.sortIMG = "sort.png";

			//Request.Query["sortOrder"] check 
			if (Request.Query.ContainsKey("sortOrder"))
			{
				this.MongoDevicesList = GetDevicesbyid();
				ViewData["MongoDevicesListModel"] = this.MongoDevicesList;
				ViewData["RoomListModel"] = GetRoomData();


			}
			else if (!Request.Query.ContainsKey("sortOrder") && Request.Query.Keys.Count() > 0)
			{
				SearchDevices();
			}
			else
			{

				this.MongoDevicesList = GetAllDevices();
				ViewBag.roomIdSortParm = "?sortOrder=roomId";
				ViewData["MongoDevicesListModel"] = this.MongoDevicesList;
				ViewData["RoomListModel"] = GetRoomData();


			}


			return View();
		}
		public ActionResult ReturnUrl()
		{
			if (Request.Cookies.TryGetValue("returnUrl", out string url))
			{
				Response.Cookies.Delete("returnUrl");
				return Redirect(url);

			}
			else
			{
				return RedirectToAction("Devices");
			}
		}
		[Route("Devices/Devices/{id}")]
		public IActionResult Devices(string id) {
			ViewData["MongoDevicesListModel"] = GetAllDevices().Where(x=>x.roomId==id).ToList();
			ViewData["RoomListModel"] = GetRoomData();

			return View();
		}

		[Route("Devices/DevicesChart")]
		public ActionResult DevicesChart()
		{
			//string id  = Request.Query["roomID"];

			List<DevicesListModel> lists = GetAllDevices();

			ViewBag.charttitle = Request.Query["title"];
			ViewBag.chartType = Request.Query["chartType"];
			ViewBag.position = Request.Query["position"];
			ViewBag.download = Request.Query["download"];

			ViewBag.datasets = ChartData(lists, Request.Query["sensorType"]);

			ChartController chart = new ChartController();

			ViewBag.day = chart.GetChartTime();
			ViewBag.divId = chart.GetRandomDivId();

			return PartialView("_DevicesChart");
		}
		[Route("Devices/DevicesChartByRoomid")]
		public ActionResult DevicesChartByRoomid()
		{
			string id = "";
			id = Request.Query["roomID"];
			//  $("#sensorChartHS").load("@Url.Action("SensorsChartByRoomid", "Sensors", new { roomID = ViewData["roomID"], title = "Humidity Sensor Log Record", chartType = "line", position = "top", sensorType = "HS" })", function () {});
			//$("#sensorChartLS").load("@Url.Action("SensorsChartByRoomid", "Sensors", new { roomID = ViewData["roomID"], title = "Luminosity Sensor Log Record", chartType = "line", position = "top", sensorType = "LS" })", function () {});

			List<DevicesListModel> lists = GetAllDevices().Where(x => x.roomId.Contains(id)).ToList();
			Debug.WriteLine("list: " + lists.ToJson().ToString());
			Debug.WriteLine("list: " + Request.QueryString);
			Debug.WriteLine("roomID: " + Request.Query["roomID"]);
			Debug.WriteLine("title: " + Request.Query["title"]);
			Debug.WriteLine("chartType: " + Request.Query["chartType"]);
			Debug.WriteLine("position: " + Request.Query["position"]);
			Debug.WriteLine("sensorType: " + Request.Query["sensorType"]);
			//Debug.WriteLine(Setgroup(lists).ToJson().ToString());
			ViewBag.charttitle = Request.Query["title"];
			ViewBag.chartType = Request.Query["chartType"];
			ViewBag.position = Request.Query["position"];
			ViewBag.download = Request.Query["download"];

			ChartController chart = new ChartController();

			ViewBag.day = chart.GetChartTime();
			ViewBag.datasets = ChartData(lists, Request.Query["sensorType"]);
			ViewBag.divId = chart.GetRandomDivId();
			
			return PartialView("_DevicesChart");
		}
		[Route("Devices/SearchDevicesByRoomid")]
		public IActionResult SearchDevicesByRoomid()
		{
			string id = Request.Query["roomID"];

			ViewData["MongoDevicesListModel"] = GetAllDevices().Where(x => x.roomId == id).ToList();
			ViewData["RoomListModel"] = GetRoomData();
			ViewData["roomID"] = id;
			//getAllDevices().Where(x => x.roomId == id).ToList().ToJson().ToString()
			return PartialView("_DevicesList");

		}
		public void SearchDevices()
		{

			ViewData["Title"] = "Search Devices";
			var list = GetAllDevices();
			List<DevicesListModel> sum = new List<DevicesListModel> { };

			List<DevicesListModel> get=new List<DevicesListModel> { };
			if (Request.Query.ContainsKey("roomId")) {
				/*			List<MongoDevicesListModel> list = getAllDevices().Where(x => x.roomId == id).ToList();
			Debug.WriteLine(list);
			ViewData["MongoDevicesListModel"] = list;
			ViewData["RoomListModel"] = GetRoomData();
*/
				if (Request.Query["roomId"] != string.Empty || Request.Query["roomId"] != "")
				{ 
					Debug.WriteLine("\n Request ContainsKey roomId");
				list = list.Where(ls => ls.roomId.Contains(Request.Query["roomId"])).ToList();
				Debug.WriteLine(list.ToJson().ToString());
				}
			}
			foreach (String key in Request.Query.Keys)
			{
				Debug.WriteLine("in foreach ....");

				string skey = key;
				string keyValue = Request.Query[key];


				switch (skey) {					
					case "AC":
					case "LT":
					case "HD":
					case "EF":
						get = list.Where(ls => ls.devicesId.Contains(skey) ).ToList();
						break;
				}
				if (key != "roomId") {
				sum.AddRange(get);
				sum = sum.Distinct().ToList();//delet double data
					Debug.WriteLine("befor Distinct \n" + sum.ToJson().ToString());

				}

			}
			if (Request.Query.Keys.Count() !=1 || Request.Query["roomId"] != "")
			{
				list = list.Intersect(sum).ToList();
				Debug.WriteLine("befor Intersect \n" + list.ToJson().ToString());
			}
			


			ViewData["MongoDevicesListModel"] = list;

			ViewData["RoomListModel"] = GetRoomData();
		}
		[Route("Devices/AddDevices")]
		public ActionResult AddDevices()//display add sensors form
		{
			ViewBag.viewType = "Add";
			ViewData["RoomListModel"] = GetRoomData();
			ViewBag.action = "AddDevicesData";

			return PartialView("_AddDevices");
		}
		[Route("Devices/AddDevices/{id}")]
		public ActionResult AddDevices(string id)//display add sensors form
		{
			ViewBag.viewType = "Add";
			ViewData["RoomListModel"] = GetRoomData();
			ViewBag.action = "AddDevicesData";
			ViewBag.CheckRoomid = id;

			return PartialView("_AddDevices");
		}
		[Route("Devices/EditDevices/{id}")]
		public ActionResult EditDevices(string id)
		{
			ViewData["EditDevicesListModel"] = GetAllDevices().Where(t => t.devicesId == id).ToList();
			Debug.WriteLine(GetAllDevices().Where(t => t.devicesId == id).ToList().ToJson().ToString());
			ViewBag.viewType = "Edit";
			ViewBag.action = "UpdateDevicesData";

			return PartialView("_AddDevices");
		}
		[Route("Devices/DropDevices/{id}")]
		public ActionResult DropDevices(string id)//display Drop sensors form
		{
			ViewData["EditDevicesListModel"] = GetAllDevices().Where(t => t.devicesId == id).ToList();

			ViewBag.viewType = "Drop";
			ViewBag.action = "DropDevicesData";

			return PartialView("_AddDevices");
		}
		[Route("Devices/AddDevicesData")]
		[HttpPost]
		public ActionResult AddDevicesData(MongoDevicesListModel postData)//post
		{
			DevicesListModel insertList = new DevicesListModel { };

			var all = GetAllDevices();
			string count = "";
			if (all.Count < 10) { count = "00" + (all.Count+1).ToString(); }
			else if (all.Count < 100) { count = "0" + (all.Count + 1).ToString(); }
			DateTime nowData = new DateTime();

			//sensortype = postData.Sensortype;
			insertList.roomId = postData.roomId;
			insertList.devicesId = postData.devicesId + count;
			insertList.devices_Name = postData.devices_Name;
			insertList.pos_x = postData.pos_x;
			insertList.pos_y = postData.pos_y;
			insertList.desc = postData.desc;
			insertList.lastest_checking_time = DateTime.UtcNow;
			insertList.total_run_time = nowData;
			insertList.power = 0;

			Getconn().InsertOneAsync(insertList);
			return ReturnUrl();
		}
		[Route("Devices/DropDevicesData")]
		[HttpPost]
		public ActionResult DropDevicesData(MongoDevicesListModel postData)//post
		{
			var DeleteResult = Getconn().DeleteOne(de => de.devicesId==postData.devicesId & de.roomId == postData.roomId);

			return ReturnUrl();
		}
		[Route("Devices/UpdateDevicesData")]
		[HttpPost]
		public ActionResult UpdateDevicesData(MongoDevicesListModel postData)
		{
			Debug.WriteLine(postData.ToJson().ToList());
			var filter = Builders<DevicesListModel>.Filter.Eq("devicesId", postData.devicesId);
			var type = postData.GetType();
			var props = type.GetProperties();
			foreach (var property in props)
			{
				if (!property.Name.Equals("_id"))
				{
					if (property.GetValue(postData) != null)
					{
						UpdateDefinition<DevicesListModel> up;
						if (property.Name == "latest_checking_time")
						{
							up = Builders<DevicesListModel>.Update.Set(property.Name.ToString(), DateTime.UtcNow);
						}
						else
						{
							up = Builders<DevicesListModel>.Update.Set(property.Name.ToString(), property.GetValue(postData).ToString());

						}
						var UpdateResult = Getconn().UpdateOne(filter, up);
						if (UpdateResult.IsAcknowledged)
						{
							if (UpdateResult.ModifiedCount != 1)
							{
								throw new Exception(string.Format("Count [value:{0}] after Modifi is invalid", UpdateResult.ModifiedCount));
							}
						}
						else
						{
							throw new Exception(string.Format("Delete for [_id:{0}] was not acknowledged", postData.devicesId.ToString()+"."+property.Name.ToString()));
						}
						//this.isUpdated = Updated.IsAcknowledged;
					}
				}
			}
			return ReturnUrl();
		}


		public List<DevicesListModel> GetAllDevices() {			
			var collection = Getconn();
			IQueryable<DevicesListModel> query = from d in collection.AsQueryable<DevicesListModel>() select d;
			List<DevicesListModel> list=new List<DevicesListModel>();
			foreach (var get in query.ToList()) {

				DateTime nowData = DateTime.Now;
				DateTime runtime = get.total_run_time;
				TimeSpan count = new TimeSpan(nowData.Ticks - runtime.Ticks);

				double currentValue = GetCurrentValue(get.devicesId);
				double avgPowers = get.power/ count.TotalDays;
				avgPowers = Convert.ToDouble(avgPowers.ToString("0.00"));

				var data = new DevicesListModel()
				{
					_id = get._id,
					listId = get.listId,
					roomId = get.roomId,
					devicesId = get.devicesId,
					devices_Name= get.devices_Name,
					power= get.power,
					lastest_checking_time = get.lastest_checking_time,
					total_run_time = get.total_run_time,
					pos_x=get.pos_x,
					pos_y=get.pos_y,
					desc = get.desc,
					current= currentValue,
					powerOnOff = false,
					avgPower= avgPowers
				};
				//Debug.WriteLine(data.current);
				list.Add(data);
			}

			MongoDevicesList = query.ToList();
			return list.ToList();
		}
		public List<DevicesListModel> GetDevicesListByRoomid(string id)
		{
			Debug.WriteLine(GetAllDevices().Where(d => d.roomId.Contains(id)).ToList().ToJson().ToString());
			return GetAllDevices().Where(d => d.roomId.Contains(id)).ToList();
		}
		public List<DevicesListModel> GetDevicesbyid() {
			List<DevicesListModel> list = null;
			string sortOrder = Request.Query["sortOrder"];
			sortOrder=ChangeSortLink(sortOrder);

			if (Request.Query.ContainsKey("sortOrder")is false)
			{
				ViewBag.sortIMG = "sort.png";

			}
			else if (sortOrder.Contains("Desc"))
			{
				list = GetAllDevices().OrderByDescending(item => item.roomId).ToList();
				//.Sort.Descending(sortOrder[0..^5]);
				ViewBag.sortIMG = "sort_desc.png";

			}
			else
			{

				ViewBag.sortIMG = "sort.png";

				list = GetAllDevices().OrderBy(item => item.roomId).ToList();

			}
			return list;
		}
		public string ChangeSortLink(string sortOrder)
		{
			//int count = Request.Query.Keys.Count;
			var rs = "";
			bool isfirst = true;
			foreach (String key in Request.Query.Keys)
			{
				string skey = key;
				string keyValue = Request.Query[key];
				if (!key.Equals("sortOrder"))
				{
					if (isfirst == true)
					{
						rs = skey + "=" + keyValue;
						isfirst = false;
					}
					else
					{
						rs += "&" + skey + "=" + keyValue;

					}
				}
			}
			/*
			string sort = null;
			switch (sortOrder) {
				case "devicesId":
					string viewsortOrderdevicesId = sortOrder == "devicesId" ? "devicesId_Desc" : "devicesId";

					ViewBag.devicesIdSortParm = "?sortOrder=" + viewsortOrderdevicesId + "&" + rs;
					if (viewsortOrderdevicesId.Equals("desc")) { sort = "sort_desc"; } else { sort = "sort"; }
					ViewBag.sortdevicesIdIMG = sort+".png";
					break;
				case "roomId":
					string viewsortOrderroomId = sortOrder == "roomId" ? "roomId_Desc" : "roomId";

					ViewBag.roomIdSortParm = "?sortOrder=" + viewsortOrderroomId + "&" + rs;
					if (viewsortOrderroomId.Equals("desc")) { sort = "sort_desc"; } else { sort = "sort"; }
					ViewBag.sortroomIdIMG = sort + ".png"; break;
				case "devices_Name":
					string viewsortOrderdevices_Name = sortOrder == "devices_Name" ? "devices_Name_Desc" : "devices_Name";

					ViewBag.devices_NameSortParm = "?sortOrder=" + viewsortOrderdevices_Name + "&" + rs;
					if (viewsortOrderdevices_Name.Equals("desc")) { sort = "sort_desc"; } else { sort = "sort"; }
					ViewBag.sortdevices_NameIMG = sort + ".png"; break;
				case "power":
					string viewsortOrderpower = sortOrder == "power" ? "power_Desc" : "power";

					ViewBag.powerSortParm = "?sortOrder=" + viewsortOrderpower + "&" + rs;
					if (viewsortOrderpower.Equals("desc")) { sort = "sort_desc"; } else { sort = "sort"; }
					ViewBag.sorpowerdIMG = sort + ".png";
					break;
				case "lastest_checking_time":
					string viewsortOrderlastest_checking_time = sortOrder == "lastest_checking_time" ? "roomId_Desc" : "lastest_checking_time";

					ViewBag.lastest_checking_timeSortParm = "?sortOrder=" + viewsortOrderlastest_checking_time + "&" + rs;
					if (viewsortOrderlastest_checking_time.Equals("desc")) { sort = "sort_desc"; } else { sort = "sort"; }
					ViewBag.sortlastest_checking_timeIMG = sort + ".png";
					break;
				case "total_run_time":

					break;
			}*/
			return sortOrder;
		}
		public List<RoomsListModel> GetRoomData()
		{
			ConnectDB conn = new ConnectDB();
			var database = conn.Conn(); 
			var RoomDataList = new List<RoomsListModel> { };
			IMongoCollection<RoomsListModel> collection = database.GetCollection<RoomsListModel>("ROOM");

			// sorting

			var sort = Builders<RoomsListModel>.Sort.Ascending("roomId");

			//end sorting

			var RoomsDocuments = collection.Find(new BsonDocument()).Sort(sort);

			foreach (RoomsListModel set in RoomsDocuments.ToList())
			{
				var data = new RoomsListModel()
				{
					roomId = set.roomId,
				};
				RoomDataList.Add(data);
			}

			return RoomDataList;
		}
		public double GetCurrentValue(string Id)
		{
			ConnectDB conn = new ConnectDB();
			var database = conn.Conn();

			IMongoCollection<BsonDocument> collection;
			FilterDefinition<BsonDocument> filter;
			var dbStr =  Id.Substring(0, 2) switch
			{
				"EF" => "EXH_FAN",
				"AC" => "AC",
				"LT" => "LIGHT",
				"HD" => "HUM",
				_ => ""
			};
			/*
			switch (Id.Substring(0, 2))
			{				
				case "EF":
					dbStr = "EXH_FAN";
					break;
				case "AC":
					dbStr = "AC";
					break;
				case "LT":
					dbStr = "LIGHT";
					break;
				case "HD":
					dbStr = "HUM";
					break;
				default:
					break;
			}*/
			collection = database.GetCollection<BsonDocument>(dbStr);
			filter = Builders<BsonDocument>.Filter.Eq("devicesId", Id);

			var json = collection.Find(filter).FirstOrDefault();
			if (json != null)
			{
				 double value =  Convert.ToDouble(json["current"].ToString());
				return value;
				/*		switch (Id.Substring(0, 2))
						{
							case "EF":
								value = Convert.ToDouble(json["current_rmp"].ToString());
								break;
							case "AC":
								value = Convert.ToDouble(json["current_tmp"].ToString());
								break;
							case "LT":
								value = Convert.ToDouble(json["current_lum"].ToString());
								break;
							case "HD":
								value = Convert.ToDouble(json["current_hum"].ToString());
								break;
							default:
								value = 0;
									break;
						}*/
			}
			else {
				return 0;
			}
		}
		public string ChartData(List<DevicesListModel> DevicesDataList, string type)
		{
			switch (type)
			{
				case "AC":
					DevicesDataList = DevicesDataList.Where(x => x.devicesId.Contains("AC")).ToList();
					ViewBag.unit = " ";
					ViewBag.unitName = "Air Conditioning";
					break;
				case "LT":
					DevicesDataList = DevicesDataList.Where(x => x.devicesId.Contains("LT")).ToList();
					ViewBag.unit = " lm";
					ViewBag.unitName = "Light";
					break;
				case "HD":
					DevicesDataList = DevicesDataList.Where(x => x.devicesId.Contains("HD")).ToList();
					ViewBag.unit = " %";
					ViewBag.unitName = "Humidifier";
					break;
				case "EF":
					DevicesDataList = DevicesDataList.Where(x => x.devicesId.Contains("EF")).ToList();
					ViewBag.unit = " rpm";
					ViewBag.unitName = "FAN";
					break;
				default:
					
					break;
			}
			return GetChartData(DevicesDataList);
		}

		public string GetChartData(List<DevicesListModel> DevicesDataList)
		{
				ChartController chart = new ChartController();

					//chart color
					List<string> Color = new List<string>();
					//sensor log


					List<CurrentDataModel> SensorsCurrentList = new List<CurrentDataModel>();
					//only ts

					DateTime today = DateTime.Now;


					//end set time
					List<string> labelss = new List<string>();
					List<double> data = new List<double>();

					List<object> datasets = new List<object>();
					List<object> datas = new List<object>();

					foreach (DevicesListModel get in DevicesDataList)
					{
						Color.Add(chart.GetRandomColor());
						labelss.Add(get.devicesId);
						SensorsCurrentList = GetChartDataList(get.devicesId).Where(x => x.latest_checking_time > today.AddDays(-1)).OrderBy(x => x.latest_checking_time).ToList();
				Debug.WriteLine("line 596 :" + DevicesDataList.ToJson().ToString());

				DateTime ca = today;
						TimeSpan catime = ca - ca.AddDays(-1);

						int counttime = Convert.ToInt32(catime.TotalMinutes / 5);

						for (int x = 0; x <= counttime; x++)
						{
							data.Add(0);

						}
						if (SensorsCurrentList.Count() != 0)
						{
							foreach (CurrentDataModel getCurrent in SensorsCurrentList)
							{
						Debug.WriteLine("line 615 : "+SensorsCurrentList.ToJson().ToString());

						var value = Convert.ToDouble(Convert.ToDouble(getCurrent.current).ToString("0.00"));

								ca = DateTime.Now.AddDays(-1);

								for (int x = 0; x <= counttime; x++)
								{
									var bo = getCurrent.latest_checking_time >= ca && getCurrent.latest_checking_time <= ca.AddMinutes(5);

									ca = ca.AddMinutes(5);
									if (getCurrent.latest_checking_time > ca && getCurrent.latest_checking_time < ca.AddMinutes(5))
									{
										data[x] = value;
									}
								}
							}
						}
						else
						{
						}
						datas.Add(data.ToArray());
					}

					for (int i = 0; i < DevicesDataList.Count; i++)
					{
						labelss.Add(DevicesDataList[i].devicesId);
					}

					return chart.LineChart(DevicesDataList.Count, labelss, datas);
			
		}
		public List<CurrentDataModel> GetChartDataList(string id)
		{

					string tableName = "";
					List<CurrentDataModel> List = new List<CurrentDataModel>();
					IMongoCollection<CurrentDataModel> collection;
					
			//db collection
			tableName = id.Substring(0, 2) switch
			{
				"EF" => "EXH_FAN",
				"AC" => "AC",
				"LT" => "LIGHT",
				"HD" => "HUM",
				_ => ""
			};
			collection = new DBManger().DataBase.GetCollection<CurrentDataModel>(tableName);
					IQueryable<CurrentDataModel> query;
					query = from c in collection.AsQueryable<CurrentDataModel>() orderby c.latest_checking_time descending where c.sensorId.Contains(id) select c;
					return query.ToList();	
		}
		public string[] typeName= { "Air Conditioning", "Light", "Humidifier", "EXH_FAN" };

		public int GetDeviceCount(string TypeName) {
			string shortName="";
			switch (TypeName)
			{
				case "Air Conditioning":
					shortName = "AC";
					break;
				case "Light":
					shortName = "LT";
					break;
				case "Humidifier":
					shortName = "HD";
					break;
				case "EXH_FAN":
					shortName = "EF";
					break;
				default:
					break;
			}
			return GetAllDevices().Where(c => c.devicesId.Contains(shortName)).Count();
			
		}
	}
}