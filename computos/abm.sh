clear
		echo "Menu Gestion de usuarios/grupos"
		echo "1)Alta Grupo"
		echo "2)Baja Grupo"
		echo "3)Modificacion Grupo"
		echo "4)Alta Usuario"
		echo "5)Baja Usuario"
		echo "6)Modificacion Usuario"
		echo "7)Listar USUARIO"
		echo "8)Listar GRUPO"
		echo "9)Control de usuarios"
		echo "0)Salir"
		
		read option
		
		case $option in
			
			1)clear
				sh altg.sh
				
				;;
			
			2)clear
				sh bajg.sh
				;;
			
			3)clear	
				sh modgck.sh
				;;
			
			
			4)clear
				sh altu.sh
				
				;;
			
			5)clear
				sh baju.sh
				;;
			
			6)clear
				sh moduck.sh
				;;
				
			7)clear
				sh list.sh
				;;
				
			8)clear
				sh list2.sh
				;;
			
			9)clear
				sh usercontrol.sh
				;;
			
			0)clear
				sh maincc.sh

				;;				
				
			*)clear
				sh abm.sh

				;;				
				                                

		
		esac


	
	
