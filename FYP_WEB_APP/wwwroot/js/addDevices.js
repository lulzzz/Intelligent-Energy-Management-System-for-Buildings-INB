//addDevices
document.write(
    "<div class=\"modal fade\" id=\"addDevices\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel\"aria-hidden=\"true\">"+
    "<div class=\"modal-dialog modal-dialog-centered\" role=\"document\">"+
      "<div class=\"modal-content\">"+
        "<div class=\"modal-header\">"+
          "<h5 class=\"modal-title\" id=\"exampleModalLabel\">"+"Add Devices"+"</h5>"+
          "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">"+
            "<span aria-hidden=\"true\">"+"&times;"+"</span>"+
          "</button>"+
        "</div>"+
        "<div class=\"modal-body p-2\">"+
          "<div class=\"row mx-3 justify-content-center align-items-center  pb-2\">"+
            "<label class=\"col h5\" for=\"ADDDevicesName\">"+"Devices Name:"+"</label>"+
            "<div class=\"col\">"+
              "<input type=\"text\" class=\"form-control bg-white\" id=\"ADDDevicesName\" name=\"ADDDevicesName\"placeholder=\"Name\" required readonly>"+
            "</div>"+ 
          "</div>"+  
          "<br>"+
           "<div class=\"row mx-3 justify-content-center align-items-center  pb-2\">"+
            "<label class=\"col h5\" for=\"ADDDevicestype\">"+"Devices type:"+"</label>"+
            "<div class=\"col\">"+
                                        
                "<select class=\"form-control bg-white\" id=\"ADDDevicestype\" name=\"ADDDevicestype\" placeholder=\"type\" required >"+
                  "<option value=\"l\">"+"light"+"</option>"+
                  "<option value=\"a\">"+"Air Conditioning"+"</option>"+
                "</select>"+
            "</div>"+ 
          "</div>"+  
          "<br>"+
 
               "<div class=\"row mx-3 justify-content-center align-items-center  pb-2\">"+
                "<label class=\"col h5\" for=\"ADDDeviceslocation\">"+"Devices location:"+"</label>"+
                "<div class=\"col\">"+
                  "<input type=\"text\" class=\"form-control bg-white\" id=\"ADDDeviceslocation\" name=\"ADDDevicesName\"placeholder=\"location\" required readonly>"+
                "</div>"+ 
              "</div>"+  
              "<br>"+
        "</div>"+
        "<!--end modal body-->"+
        "<div class=\"modal-footer\">"+
          "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">"+"Close"+"</button>"+
          "<button type=\"button\" class=\"btn btn-primary\">"+"Save changes"+"</button>"+
        "</div>"+
      "</div>"+
    "</div>"+
  "</div>"+
  "<!--adddevices -->"+"");

           