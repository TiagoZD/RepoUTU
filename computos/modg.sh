clear
				echo "MODIFICACION GRUPOS"
                                echo "1)Cambiar Nombre"
                                echo "2)Cambiar Contraseña"
				echo "3)Agregar miembros"
				echo "4)Eliminar miembros"
                                echo "0)Salir"
                                read choose

                                case $choose in     

                                        1)  clear
						sh modg1.sh
						 ;;

                                        2)  clear 
						sh modg2.sh
						 ;;
				 	
					3)  clear

						sh modguck.sh	
						 ;;
			
					4)  clear
						
						sh modguck2.sh
						 ;;

					0)clear
						sh abm.sh
						 ;;
					
					*) echo "OPCION INVALIDA"
						 read aux
						 sh modg.sh
						 ;;
				esac						
