insert into compromissos (
id_contatos,
datacompromisso,
localcompromisso,
diassemana,
descricao,
titulo
)
values(
12,
'2001-09-04',
'Blumenau',
'Domingo',
'Ir trajada',
'Tomar Chopp'
);

select con.nome,
com.titulo,
com.descricao,
com.localcompromisso,
com.datacompromisso,
com.diassemana
from contatos as con,
compromissos as com;

select * from compromissos;

Delete from compromissos where id_contatos = 9;

update compromissos set
datacompromisso = '2002-10-04',
localcompromisso = 'Indaial',
diassemana = 'Segunda',
descricao = 'Sem roupa',
titulo = 'Fazer nada'
where id_contatos = 9;

select 
com.id_contatos,
con.nome,
com.titulo,
com.descricao,
com.localcompromisso,
com.datacompromisso,
com.diassemana
from contatos as con
join compromissos as com
on com.id_contatos = con.id;
