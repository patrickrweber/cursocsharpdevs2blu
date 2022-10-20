insert into contatos (
nome,
telefone,
email,
celular,
rua,
numero,
bairro,
cep,
cidade,
uf)
values(
'Patrick15',
'47 3331-4150',
'patrick@gmail.com',
'47 989098585',
'Leopoldo Haerchen',
658,
'Badenfurt',
'89074-650',
'Blumenau',
'SC');

select * from contatos;

select id from contatos order by id desc limit 1;

select 
id,
nome,
telefone,
celular,
email,
cep,
rua,
numero,
bairro,
cidade,
uf
From contatos;

Delete from contatos where id = 6;

Update contatos
set 
nome = 'VAlentina',
telefone = '47 33314150',
celular = '47 989098585',
email = 'valentina@gmail.com',
cep = '89072-040',
rua = 'Oswaldo Cruz',
numero = 686,
bairro = 'Velha',
cidade = 'Blumenau',
uf = 'SC'
Where id = 7;
