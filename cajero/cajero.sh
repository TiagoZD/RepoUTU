clear
echo "CAJERO AUTOMATICO"
echo "1)CONSULTA DE SALDO"
echo "2)DEPOSITO"
echo "3)RETIRO"
echo "4)TRANSFERENCIAS"
echo "0)SALIR"

read option

case $option in
	
	1) clear
		sh asksaldo.sh

		;;
	
	2) clear
		sh moneydep.sh

		;;
	
	3) clear
		sh askretiro.sh

		;;
	
	4) clear
		sh asktrans.sh

		;;
	
	0) clear
		exit

		;;

	*) clear
		sh cajero.sh

		;;	
esac

