É
^D:\work-git-aula\andre-corte\sonarqube\src\SonarQube.Poc.Application\Services\MembroService.cs
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
 
Application

 #
.

# $
Services

$ ,
{ 
public 

class 
MembroService 
:  
IMembroService! /
{ 
private 
readonly 
MembroRepository )
_membroRepository* ;
;; <
public 
MembroService 
( 
MembroRepository -
membroRepository. >
)> ?
{ 	
_membroRepository 
= 
membroRepository  0
;0 1
} 	
public 
IEnumerable 
< 
Membro !
>! "
Listar# )
() *
)* +
{ 	
return 
_membroRepository $
.$ %
Listar% +
(+ ,
), -
;- .
} 	
} 
} 