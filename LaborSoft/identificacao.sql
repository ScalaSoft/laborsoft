
-- Table: identificacao
CREATE TABLE identificacao ( 
    cod_area               VARCHAR( 255 ),
    area                   VARCHAR( 255 ),
    nome_subarea           VARCHAR( 255 ),
    tipo_logradouro        VARCHAR( 255 ),
    nome_logradouro        VARCHAR( 255 ),
    numero_logradouro      INTEGER( 10 ),
    compl_logradouro       VARCHAR( 255 ),
    bairro                 VARCHAR( 255 ),
    cep                    VARCHAR( 40 ),
    setor_quadra           VARCHAR( 255 ),
    selo_lote              VARCHAR( 255 ),
    domicilio              VARCHAR( 255 ),
    primeiro_no_domicilio  BOOLEAN,
    num_fam_dom            NUMERIC( 10 ),
    num_pess_fam           NUMERIC( 10 ),
    mulher_resp_fam        BOOLEAN,
    deficiente_fam         BOOLEAN,
    num_port_def           NUMERIC,
    possui_cadeirante      BOOLEAN,
    deficiencia_mobilidade BOOLEAN,
    cadunico               BOOLEAN,
    numero_nis             NUMERIC,
    renda_familiar         VARCHAR,
    complemento            VARCHAR( 255 ),
    nome_entrevistado      VARCHAR( 255 ),
    id                     INTEGER         PRIMARY KEY AUTOINCREMENT
                                           NOT NULL
                                           DEFAULT ( 0 ) 
);

INSERT INTO [identificacao] ([cod_area], [area], [nome_subarea], [tipo_logradouro], [nome_logradouro], [numero_logradouro], [compl_logradouro], [bairro], [cep], [setor_quadra], [selo_lote], [domicilio], [primeiro_no_domicilio], [num_fam_dom], [num_pess_fam], [mulher_resp_fam], [deficiente_fam], [num_port_def], [possui_cadeirante], [deficiencia_mobilidade], [cadunico], [numero_nis], [renda_familiar], [complemento], [nome_entrevistado], [id]) VALUES (123234, 'Favelas', 'sfasdf', 'asdfsadf', 'asdfasdfasdf', 232, 'asdfasdfasdf', 'asdasd', 13560044, '', '', '', '', '', '', '', 0, '', 0, 0, 0, '', '', 'asdasd', 'Alvaro', 20);
