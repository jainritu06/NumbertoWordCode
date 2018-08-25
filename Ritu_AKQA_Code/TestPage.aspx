<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="Ritu_AKQA_Code.TestPage" %>

<!DOCTYPE html>  
<html xmlns="http://www.w3.org/1999/xhtml">  
<head runat="server">  
    <title></title>  
    <script src="http://code.jquery.com/jquery-1.7.1.min.js" type="text/javascript"></script>  
     <script>  
         $(document).ready(function () { 
             $("#table").hide();
             $("#Submit").click(function () {  
                 var person = new Object();  
                 person.name = $('#name').val();  
                 person.number = $('#number').val();  
                 $.ajax({  
                     url: '/api/NumberToWord',  
                     type: 'POST',  
                     dataType: 'json',  
                     data: person,  
                     success: function (data, textStatus, xhr) {  
                         console.log(data);
                         $("#table").show();
                         $('#inputName').html($('#name').val());
                         $('#inputNumber').html($('#number').val());
                         $.each(data, function( key, val ) {
                             if(key=="Name")
                                 $('#outputName').html(val);
                             if(key=="Number")
                                 $('#outputNumber').html(val);
  });

                      },  
                     error: function (xhr, textStatus, errorThrown) {  
                         console.log('Error in Operation');  
                     }  
                 });  
             });  
         });  
    </script>  
</head>  
<body>  
    <form id="form1">  
        Name :- <input type="text" name="name" id="name" /> <br /> 
        <br />
        Number:- <input type="number" name="number" id="number" />  <br />
        <br />
        <input type="button" id="Submit" value="Submit" /> <br /> <br />
        <table border="1" id="table">
            <tr>
                <td><b>Input</b></td>
                <td><b>Output</b></td>
            </tr>
            <tr>
                <td id="inputName"></td>
                <td id="outputName"></td>
            </tr>
            <tr>
                <td id="inputNumber"></td>
                <td id="outputNumber"></td>
            </tr>

        </table>
    </form>  
</body>  
</html>  