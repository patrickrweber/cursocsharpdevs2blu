select pessoa.id as codigo_pessoa,
		pessoa.nome as nome_pessoa,
        pessoa.cgccpf as cpf,
        pessoa.endereco,
        pessoa.tipo_pessoa,
        b.crm,
        b.especialidade,
        b.setor,
        b.tipo_prestador,
        b.tipo_fornecedor
from pessoa
join prestador as b
on pessoa.id = b.id_pessoa;

select p.id as codigo_pessoa,
		p.nome as nome_pessoa,
        p.cgccpf as cpf,
        p.endereco,
        p.tipo_pessoa,
        b.convenio,
        '' as crm,
        '' as especialidade,
        '' as setor,
        '' as tipo_prestador,
        '' as tipo_fornecedor
from pessoa as p
join paciente as b
on (p.id = b.id_pessoa)
union
select p.id as codigo_pessoa,
		p.nome as nome_pessoa,
        p.cgccpf as cpf,
        p.endereco,
        p.tipo_pessoa,
        '' as convenio,
        b.crm,
        b.especialidade,
        b.setor,
        b.tipo_prestador,
        b.tipo_fornecedor
from pessoa as p
join prestador as b
on (p.id = b.id_pessoa)
;

