clear
echo "Ingrese el nombre del grupo"
read nombreg
clear
gcheck=$(grep -w $nombreg /etc/group | cut -d ":" -f1)

if [ "$nombreg" = "$gcheck" ]
	then
		echo "EL GRUPO YA EXISTE"
		read aux
		sh abm.sh
	
	else
		groupadd $nombreg
		echo "EL GRUPO SE HA CREADO SATISFACTORIAMENTE"
		read aux
		logger -p local4.info "Grupo creado: $nombreg"
		sh abm.sh
fi
