clear
echo "Menu de Gestion de Procesos"
echo "___________________________"
echo "1)Visualizar procesos"
echo "2)Matar procesos"
echo "3)Volver"
read option

case $option in
	
	1) sh gprocop.sh
		clear
		;;

	2) sh gprock.sh	
		clear
		;; 

	3) sh maincc.sh
		;;
esac
