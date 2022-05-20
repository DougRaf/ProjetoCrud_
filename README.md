# ProjetoCrud_
Projeto de teste para vaga de desenvolvedor na MFRural

# Instruções
Para executar esse projeto basta somente abri-lo no visual studio 2022 e executar o projeto!!!
Não há a necessidade de ultilizar um migrate para criar o banco pois o banco de dados usado é remoto!!!

# Comandos
Caso queira realizar a troca do banco usar essas dependencias e aplicatar os comandos necessarios para criar a base de dados !!!

Pacotes instalados
Install-Package Microsoft.EntityFrameworkCore
Install-Package Microsoft.EntityFrameworkCore.Design
Install-Package Pomelo.EntityFrameworkCore.MySql

Comandos do Migration executados para criação do banco
Add-Migration Criacao-Inicial -Context Contexto
Update-Database -Context Contexto

Atenção!!!!
Não se esqueça de alterar a string de conecxão do banco caso queira testar o migrate em uma nova base de dados (Program.cs <build service contexto> ) !!!
