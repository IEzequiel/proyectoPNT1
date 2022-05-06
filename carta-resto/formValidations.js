function required()
{
let nomb = document.forms["formulario"]["nombre"].value;
let apell = document.forms["formulario"]["apellido"].value;
let email = document.forms["formulario"]["email"].value;
let tel = document.forms["formulario"]["tel"].value;
let dir = document.forms["formulario"]["dir"].value;
let pedido = document.forms["formulario"]["pedido"].value;
if (nomb == "")
{
alert("Ingrese nombre");
return false;
    } else if (apell == "") {
    alert("Ingrese Apellido")
    return false;
        }
        else if (email == "") {
            alert("Ingrese mail")
            return false;
             } 
            else if (tel == "") {
            alert("Ingrese telefono")
            return false;
             }
              else if (dir == "") {
                alert("Ingrese direccion")
                return false;
                    }
                    else if (pedido == "") {
                        alert("Ingrese pedido")
                        return false;
                        }
                        else 
                          {
                            if (ValidarMail(document.formulario.email) && ValidarTelefono(document.formulario.tel)){
                            alert("Pedido realizado");
                            }
                          }
}

function ValidarMail(inputText)
{
var mailformat = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
if(inputText.value.match(mailformat))
{
document.formulario.email.focus();
return true; 
}
else
{
alert("Ingresaste un mail incorrecto!");
document.formulario.email.focus();
return false;
}
}

function ValidarTelefono(inputtxt)
{
  var phoneno = /^\+?([0-9]{3})\)?[-. ]?([0-9]{8})$/;
  if(inputtxt.value.match(phoneno))
        {
      
      return true;
        }
      else
        {
        alert("Numero invalido.Ej:(011)-12345678");
        return false;
        }
}