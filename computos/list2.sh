clear
echo "Ingrese el grupo a listar"
read glname
listedg=$(grep -w $glname /etc/group | cut -d ":" -f1)

if [ "$glname" = "$listedg" ]
        then
                clear
                showm=$(grep -w $glname /etc/group | cut -d ":" -f4)
                echo "NOMBRE: $glname"
                echo "MIEMBROS: $showm"
                read aux
                sh abm.sh
        else
                clear
                echo "EL GRUPO NO EXISTE"
                read aux
                sh abm.sh
fi

~                                                                               
~                                                                               


