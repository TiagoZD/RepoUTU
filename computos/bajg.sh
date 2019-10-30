clear

echo "Ingrese el nombre del grupo"
read gnombre
clear
gnameck=$(grep -w $gnombre /etc/group | cut -d ":" -f1)

if [ "$gnombre" = "$gnameck" ]
	then
		clear
		groupdel $gnombre
		echo "EL GRUPO SE HA ELIMINADO SATISFACTORIAMENTE"
		logger -p local4.info "El grupo $gnombre se ha eliminado"
		read aux
		sh abm.sh
	else
		clear
		echo "EL GRUPO NO EXISTE"
		read aux
		sh abm.sh
fi
