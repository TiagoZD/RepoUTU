clear
echo "INGRESE LA OPCION DESEADA"
echo "_________________________"
echo "1)Visualizar logs del centro de computos"
echo "2)Visualizar logs del cajero automatico"
echo "0)Volver"
read option
case $option in
	
	1)clear
		cat /var/log/computos.log
		read var
		sh glogs.sh
		;;
	
	2)clear
		cat /var/log/cajero.log
		read var
		sh glogs.sh
		;;
	
	0) clear
		sh maincc.sh
		;;

	*) sh glogs.sh
		;;

esac
