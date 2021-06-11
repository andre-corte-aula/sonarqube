›
dD:\work-git-aula\andre-corte\sonarqube\src\SonarQube.Poc.Repository\Repositorios\MembroRepository.cs
	namespace

 	
	SonarQube


 
.

 
Poc

 
.

 

Repository

 "
.

" #
Repositorios

# /
{ 
public 

class 
MembroRepository !
{ 
private 
readonly 
string 
_db  #
=$ %
$"& (
{( )
Environment) 4
.4 5
CurrentDirectory5 E
}E F
$strF [
"[ \
;\ ]
public 
IEnumerable 
< 
Membro !
>! "
Listar# )
() *
)* +
{ 	
IList 
< 
Membro 
> 
membros !
=" #
JsonConvert$ /
./ 0
DeserializeObject0 A
<A B
IListB G
<G H
MembroH N
>N O
>O P
(P Q
SystemQ W
.W X
IOX Z
.Z [
File[ _
._ `
ReadAllText` k
(k l
_dbl o
)o p
)p q
;q r
return 
membros 
. 
AsEnumerable '
(' (
)( )
;) *
} 	
} 
} 