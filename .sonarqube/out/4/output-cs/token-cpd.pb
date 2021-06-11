°
LD:\work-git-aula\andre-corte\sonarqube\src\SonarQube.Poc.IoC\BootStrapper.cs
	namespace 	
	SonarQube
 
. 
Poc 
. 
IoC 
{ 
public 

static 
class 
BootStrapper $
{		 
public

 
static

 
void

 
RegisterServices

 +
(

+ ,
IServiceCollection

, >
services

? G
)

G H
{ 	

Repository 
( 
services 
)  
;  !
Application 
( 
services  
)  !
;! "
} 	
public 
static 
T 

GetService "
<" #
T# $
>$ %
(% &
)& '
{ 	
var 
serviceCollection !
=" #
new$ '
ServiceCollection( 9
(9 :
): ;
;; <
RegisterServices 
( 
serviceCollection .
). /
;/ 0
var 
serviceProvider 
=  !
serviceCollection" 3
.3 4 
BuildServiceProvider4 H
(H I
)I J
;J K
return 
serviceProvider "
." #

GetService# -
<- .
T. /
>/ 0
(0 1
)1 2
;2 3
} 	
public 
static 
T 
Resolve 
<  
T  !
>! "
(" #
)# $
{ 	
return 

GetService 
< 
T 
>  
(  !
)! "
;" #
} 	
private!! 
static!! 
void!! 

Repository!! &
(!!& '
IServiceCollection!!' 9
services!!: B
)!!B C
{"" 	
services## 
.## 
AddTransient## !
<##! "
MembroRepository##" 2
>##2 3
(##3 4
)##4 5
;##5 6
}$$ 	
private&& 
static&& 
void&& 
Application&& '
(&&' (
IServiceCollection&&( :
services&&; C
)&&C D
{'' 	
services(( 
.(( 
AddTransient(( !
<((! "
IMembroService((" 0
,((0 1
MembroService((2 ?
>((? @
(((@ A
)((A B
;((B C
})) 	
}** 
}++ 