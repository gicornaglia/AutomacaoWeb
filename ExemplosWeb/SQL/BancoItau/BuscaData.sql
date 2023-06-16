select idt_programacao_acao_cobranca, cod_acao, dth_programacao, sgl_usuario_programacao, ind_situacao_programacao
from PROGRAMACAO_ACAO_COBRANCA 
where cod_acao = 21
and rownum = 1
order by dth_programacao desc