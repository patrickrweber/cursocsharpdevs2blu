select id,
		nome,
        datanascimento,
        idade,
        status 
from pessoa; 

select id,
		id_pessoa,
        login,
        senha,
        status
from usuario;

select  p.id as codigo_pessoa,
		u.id as codigo_usuario,
		p.nome,
		p.datanascimento as nascimento,
        p.idade,
        p.status as situacao_pessoa,
        u.login,
        u.senha,
        u.status as status_usuario
from pessoa as p
join usuario as u
	on p.id = u.id_pessoa
;
    
select *
from pessoa
where datanascimento < '2001-03-31'
;