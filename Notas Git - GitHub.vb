GIT

*para descargar git
git --version

*para indicar nombre del usuario que realiza modificaciones desde este equipo
git config --global user.name "fernandacancino"

*para indicar correo de quien esta realizando los cambios 
git config --global user.email "fernand4.reyes@gmail.com"

*mostrar los valores establecidos en la maquina (como name, email)
git config --global -l

*se puede sobreescribir los valores como username, email de la misma manera que se asignan*

*para realizar un commit*
*1.- se posisiona en la carpeta que se contiene el trabajo desde la terminal*
*2.- se inicia GIT*
git init

*3.- se agregan*
git add . 

*4.- se realiza commit, y se deja un mensaje*
git commit -m "se suben los cambios"

' en caso de escribrir mal un comentario, con amend se puede rectificar
git commit --ammend -m "nuevo texto de descripcion"

'para renombrar un archivo que se este subiendo'
git mv nombrearchivo.html nuevonombrearchivo.html

'eliminar un archivo'
git rm nuevonombrearchivo.html
git commit -m "se borro el archivo"

'para recuperar un archivo eliminado'
'un paso atras '
git reset --soft idDelCambioRealizado 'se puede encontrar con 'git l' muestra el historial de cambios'

 
*para saber que el status de los archivos*
git status

'PARA DESCARGAR REPOSITORIO DESDE GITHUB'

'se habre el terminal desde la carpeta, se inicia repositorio git'

git init
'situado donde se quiere descargar desde la terminal '
git clone https://github.com/FernandaCancino/portafolioAppEscritorio.git

'agregar todos cambios o modificaciones GIT ADD'
git add .
git commit -m "se han agregado cambios o se modifico x, o se agrego x"
git push origin master 

'agregar los cambios o modificaciones que uno eliga GIT ADD + la ruta '
git add build/classes/controller/Renders.class
git commit -m "se han agregado cambios o se modifico x, o se agrego x"

'para subir los cambios a GITHUB'
git push origin master

'esto solicitara el user y pass'

'para descargar cambios GIT PULL' 
'git fech = git pull, pero es mas tedioso ya que luego se realiza un merge '
git status
git pull

'se pueden ver todos los commit y sus respectivos comentarios'
git log --oneline --decorate --all --graph


'para poder descargar y subir cambios a un proyecto de otro usuario'
'1.- realizar fork, desde github'
'2.- descargar la app'
git add .
git commit 
git push origin master
se ingresan las credenciales
