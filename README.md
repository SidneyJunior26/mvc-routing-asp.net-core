## Asp.Net Core MVC

# Welcome!

## I'm (Sidney)!

:computer: I'm Full-Stack Developer!

:house_with_garden: I’m from Brazil.


## About me 🧔🏻

[![Github Badge](https://img.shields.io/badge/-Github-000?style=flat-square&logo=Github&logoColor=white&link=https://github.com/SidneyJunior26?tab=repositories)](https://github.com/SidneyJunior26?tab=repositories)

[![Linkedin Badge](https://img.shields.io/badge/-LinkedIn-blue?style=flat-square&logo=Linkedin&logoColor=white&link= https://www.linkedin.com/in/sidney-junior-0b60ba10a/)]( https://www.linkedin.com/in/sidney-junior-0b60ba10a/)

## About Project 🚀

## Portuguese 🇧🇷

Projeto desenvolvido com padrão MVC focada no back-end trabalhando com o protocolo HTTP e controle de requisições utilizando o servidor Kestrel e dois recursos muito importantes 
do framework Asp.Net Core MVC para renderizar suas views: o estágio ExecuteResult, que é onde o framework escreve a resposta HTTP a partir da view. E o motor de renderização de 
views Razor, que é a implementação padrão.

A pasta Controllers estão os controladores da aplicação. O nome de um controlador termina com o sufixo Controller e herda da classe base Controller. 
Seus métodos são actions e retornam implementações de IActionResult.

Para gerar as views temos uma estrutura de pastas que começa em Views e subpastas respectivas aos prefixos dos nomes dos controladores. Dentro de cada subpasta temos arquivos 
com extensão cshtml e neste projeto aqui existe uma correspondência entre a action e a view.

Na pasta Models estão os modelos da aplicação.

A classe de inicialização da aplicação possui os métodos ConfigureServices(), que adiciona o serviço MVC, e o método Configure(), que além de outras coisas define o roteamento 
padrão do framework MVC.

A classe Program tem o código que sobe o host a partir das configurações do hospedeiro web (usando Kestrel e classe de inicialização Startup).

## English 🇺🇸

Project developed with MVC pattern focused on the back-end working with the HTTP protocol and request control using the Kestrel server and two very important features
from the Asp.Net Core MVC framework to render your views: the ExecuteResult stage, which is where the framework writes the HTTP response from the view. And the rendering engine of
Razor views, which is the default implementation.

In the Controllers folder are the application controllers. A controller name ends with the Controller suffix and inherits from the Controller base class.
Its methods are actions and return implementations of IActionResult.

To generate the views, we have a folder structure that starts with Views and subfolders corresponding to the controller name prefixes. Within each subfolder we have files
with cshtml extension and in this project here there is a correspondence between the action and the view.

In the Models folder are the application models.

The application's initialization class has the ConfigureServices() methods, which add the MVC service, and the Configure() method, which among other things defines the routing
MVC framework pattern.

The Program class has code that pulls up the host from the web host's settings (using Kestrel and Startup initialization class).
