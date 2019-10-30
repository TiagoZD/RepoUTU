clear
var2=$(echo select tipo_cuenta, moneda_cuenta, saldo from tarjeta, cuenta where tarjeta.id_cuenta = cuenta.id_cuenta AND numt = $nrot | dbaccess databank > consulta)
clear
cat consulta | head -5 | tail -1
echo "Presiona enter para continuar..."
read var
sh cajero.sh






