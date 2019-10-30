clear
echo "Ingrese el usuario a listar"
read ulname
listedu=$(grep -w $ulname /etc/shadow | cut -d ":" -f1)

if [ "$ulname" = "$listedu" ]
	then
		clear
		showp=$(grep -w $ulname /etc/shadow | cut -d ":" -f2)
		showd=$(grep -w $ulname /etc/passwd | cut -d ":" -f6)
		echo "NOMBRE: $ulname"
		echo "PASS: $showp"
		echo "DIRECTORIO: $showd"
		read aux
		sh abm.sh
	else
		clear
		echo "EL USUARIO NO EXISTE"
		read aux
		sh abm.sh
fi

