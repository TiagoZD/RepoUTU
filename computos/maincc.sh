clear
echo "CENTRO DE COMPUTOS"
echo "__________________"	
echo "1) Gestion de usuarios/grupos"
echo "2) Gestion de procesos"
echo "3) Gestion de logs"
echo "4) Estado de red"
echo "0) Salir"

read option
	case $option in
	
		1) clear
			sh abm.sh
			;;
		2) clear
			sh gproc.sh
			;;
		3) clear 
			sh glogs.sh
			;;
		
		4) clear
			ping 192.168.5.50
			read var
			sh glogs.sh
			;;
	
		0) clear
			exit
			;;
		*) sh maincc.sh
			
			;;
	esac
	

