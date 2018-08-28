Funcionalidade: Usuário vai ter uma calculadora para efetuar soma

@TesteSomaSucesso
Cenário: Usuário informar 2 números inteiros e efetuar a soma
	Dado que o usuário esteja na aplicação
	E informe no primeiro campo o valor 1
	E informe no segundo campo o valor 2
	Quando clicar em somar
	Então vai ter como resultado 3

@TesteSomaPassandoTexto
Cenário: Usuário informar em um dos campos uma letra e então validar
	Dado que o usuário esteja na aplicação
	E informe no primeiro campo o valor 1
	E informe no segundo campo o valor A
	Quando clicar em somar
	Então vai ter um alerta com o seguinte texto "Informe somente números nos campos"