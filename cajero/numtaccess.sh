clear
echo “Ingrese su PIN”
read pint
echo $nrot
read var

pincheck=$(echo select pin from tarjeta where pin = $pin AND numt = $nrot | dbaccess databank | grep -w $pin)
if [ "$pint" -eq "$pincheck" ]

	then 
		sh cajero.sh

	else
		echo "PIN INCORRECTO"
		read var
		exit
fi
