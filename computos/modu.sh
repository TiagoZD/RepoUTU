clear			
                                echo "Ingrese que modificacion quiere realizar:"
                                echo "1)Asignar a grupo"
                                echo "2)Cambiar Nombre"
                                echo "3)Cambiar Contraseña"
                                echo "0)Salir"
                                read choose2
					case $choose2 in
					1)clear
						sh modu1.sh
						
						;;

					2)clear
						sh modu2.sh
						
						;; 
						
					3) clear
						sh modu3.sh
						
						;;
					0)
						sh abm.sh
						;;
					
					*)
						sh modu.sh
						echo "OPCION INVALIDA"
						read aux
						;;
					esac

