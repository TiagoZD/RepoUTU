clear
	echo "Elija una operacion"
	echo "1)Bloquear Usuario"
	echo "2)Desbloquear Usuario"
	echo "0)Salir"
	read op
	
	case $op in
		
		1)clear
			sh lockusr.sh
			;;
		2)clear	
			sh unlockusr.sh
			;;
		0)clear
			sh abm.sh
			;;
		*)clear
			sh usercontrol.sh
			;;
	esac
