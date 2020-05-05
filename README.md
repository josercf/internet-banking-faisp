Sistema internet banking – PF


1)	Cadastro de correntista;
a.	Dados pessoais;
i.	Nome;
ii.	Data Nascimento;
iii.	CPF;
iv.	RG;
v.	Estado Civil;
vi.	....
b.	Dados de endereço;
i.	CEP
ii.	Rua
iii.	Bairro
iv.	Complemento
v.	Cidade
vi.	Estado
c.	Dados financeiros;
i.	Salário;
ii.	Patrimônio;
iii.	...
d.	Dados empregador;
i.	Empresa em que trabalha;
ii.	Tempo no emprego;
iii.	Cargo;
Sugestão layout:
Framework bootstrap;

Regras de negócio:
O usuário deverá ter idade maior ou igual a 16 anos;
Deverá morar no Brasil;
Deverá possuir um CPF válido;
Deverá ser gerado um número de conta no formato: YYyyCCC-DD EX.:(2092178-04)
Onde: 
YY – Ano em que a conta foi aberta;
yy – Ano do nascimento do correntista;
CCC – Três últimos dígitos do CPF do correntista;
DD – Dia em que a conta foi aberta;
A conta criada deverá possuir saldo = 0;
