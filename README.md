### FormAcesso - Aplicativo de Verificação de Acesso
Este é um aplicativo Windows Forms desenvolvido em C# para verificar o acesso de usuários a um evento com base em duas condições: nome e idade.

## 💡 Funcionalidade
O sistema realiza a verificação de acesso com base nas seguintes regras:

- Nome na lista: O usuário só poderá acessar se o nome estiver na lista pré-definida (Moisés, Ana ou Carlos).

- Idade: O usuário precisa ser maior de 18 anos para ser autorizado.

Quando o usuário informa seu nome e idade:

- Se a idade for inferior a 18 anos, o acesso é negado e a mensagem "Entrada negada: você é menor de idade" será exibida.

- Se o nome não estiver na lista, a mensagem "Entrada negada: seu nome não está na lista" será exibida.

- Se as duas condições forem atendidas, será exibida a mensagem de boas-vindas: "Bem-vindo ao evento, [Nome do Usuário]!".

- O formulário possui um campo para nome, um campo para idade e um botão para realizar a verificação.

## 🚀 Como Executar
Pré-requisitos:

- Microsoft Visual Studio ou Visual Studio Code com o suporte para Windows Forms.

- .NET Framework 4.8 ou superior.

Passos para rodar o projeto:
- Abra o Visual Studio ou a IDE de sua escolha que suporte C#.

- Importe o projeto ou abra a solução FormAcesso.

- Compile o projeto e execute o aplicativo:
  
```bash
dotnet run
```

- A interface gráfica será exibida, onde o usuário pode inserir seu nome e idade.

- Clique no botão Verificar para ver o resultado da verificação de acesso.

- *O aplicativo é simples, mas pode ser expandido para verificar diferentes critérios de acesso ou adicionar funcionalidades extras como persistência de dados.

## 🧠 Conceitos Abordados
- Windows Forms: Interface gráfica para o aplicativo com componentes como TextBox, Button e Label.

- Eventos: O evento de clique do botão "btnVerificar" aciona a lógica de verificação.

- Condicionais: Uso de if, else if e else para definir as condições de verificação.

- Leitura de dados do usuário: Através de controles de formulário como TextBox.

## 🛠 Tecnologias Utilizadas

- C#

- Windows Forms

- .NET Framework


# Desenvolvido 💻 por: 
- [@Devmoises79]
- Contato 📩: [https://www.linkedin.com/in/moises-aniceto-71042a251/] | Linkedin 🔗
