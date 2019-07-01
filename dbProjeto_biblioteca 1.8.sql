CREATE TABLE tbl_usuario(
	login VARCHAR(100),
	senha VARCHAR(15),
	nome_completo VARCHAR(100),
	CONSTRAINT pk_usuario PRIMARY KEY (login)
);
CREATE TABLE tbl_jogo (
	nome VARCHAR (100),
	descricao VARCHAR(1000),
	CONSTRAINT pk_jogo PRIMARY KEY (nome)
);
CREATE TABLE tbl_tem (
	id_tem SERIAL,
	fk_usuario_login VARCHAR(100),
	fk_jogo_nome VARCHAR(100),
	CONSTRAINT pk_id_tem PRIMARY KEY (id_tem),
	CONSTRAINT fk_usuario_login FOREIGN KEY (fk_usuario_login) REFERENCES tbl_usuario (login),
	CONSTRAINT fk_jogo_nome FOREIGN KEY (fk_jogo_nome) REFERENCES tbl_jogo (nome)
);

insert into tbl_jogo (nome, descricao) values ('Naruto Shippuden Ultimate ninja Storm 4' , 'Naruto Shippuden: Ultimate Ninja Storm 4, é o sexto jogo da série Ultimate Ninja Storm. É um jogo de luta, desenvolvido pelo CyberConect2 e publicado pela Namco-Bandai games para PC, PlayStation 4, e Xbox One baseado na franquia de anime e mangá Naruto.');
insert into tbl_jogo (nome, descricao) values ('Grand Theft Auto 5' , 'Grand Theft Auto V é um jogo eletrônico de ação-aventura desenvolvido pela Rockstar North e publicado pela Rockstar Games.');
insert into tbl_jogo (nome, descricao) values ('Pokémon Fire Red' , 'Pokémon FireRed Version e Pokémon LeafGreen Version são dois jogos eletrônicos da série Pokémon para o Game Boy Advance. São remakes das primeiras versões da série de Pokémon Red e Green. Os dois jogos contêm os 151 primeiros Pokémon dos jogos originais de Game Boy, assim como muitos de segunda geração.');
insert into tbl_jogo (nome, descricao) values ('Final Fantasy XV' , 'Final Fantasy XV é um jogo eletrônico de RPG de ação desenvolvido e publicado pela Square Enix. Ele foi lançado mundialmente no dia 29 de novembro de 2016 para as plataformas PlayStation 4 e Xbox One.');
insert into tbl_jogo (nome, descricao) values ('Sonic Rider' , 'Sonic Riders é um jogo electrónico de corrida da Sega para as plataformas Playstation 2, Xbox, Gamecube e PC, baseado no mundo da série de videgames Sonic the Hedgehog.');
insert into tbl_jogo (nome, descricao) values ('Call of Duty Black Ops ' , 'Call of Duty: Black Ops 4 é um jogo eletrônico de tiro em primeira pessoa desenvolvido pela Treyarch e publicado pela Activision. Foi lançado em 12 de outubro de 2018, para Microsoft Windows, Xbox One e Xbox One.');

select * from tbl_usuario
select * from tbl_jogo
select * from tbl_tem



drop table tbl_tem;
drop table tbl_jogo;