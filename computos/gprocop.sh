clear
logger -p notice local6 "Se genero un reporte"
echo "Seleccione una opcion"
echo "_____________________"
echo "1)Listar procesos"
echo "2)Listar procesos por PID"
echo "3)Listar procesos por nombre"
echo "4)Volver"
read option

case $option in
		
	1) clear
		ps aux
		read var
		sh gprocop.sh
		;;
	2)clear 
		echo "Ingrese el PID"
		read pid
		clear
		ps -p $pid
		read var
		sh gprocop.sh
		;;
	3)clear 
		echo "Ingrese el nombre"
		read pname
		clear
		ps aux | grep $pname
		read var
		sh gprocop.sh
		;;
	4)clear
		sh gproc.sh
		;;
esac
