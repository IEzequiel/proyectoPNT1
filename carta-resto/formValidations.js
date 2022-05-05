function required()
{
let nomb = document.forms["formulario"]["nombre"].value;
var apell = document.forms["formulario"]["apellido"].value;
var email = document.forms["formulario"]["email"].value;
var tel = document.forms["formulario"]["tel"].value;
var dir = document.forms["formulario"]["dir"].value;
var pedido = document.forms["formulario"]["pedido"].value;
if (nomb == "")
{
alert("Ingrese nombre");
return false;
    } else if (apell == "") {
    alert("Ingrese Apellido")
    return false;
        } else if (email == "") {
            alert("Ingrese email")
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
                     alert("Pedido realizado");
                     return true; 
                     }
}

