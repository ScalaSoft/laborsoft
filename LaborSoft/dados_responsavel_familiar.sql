
-- Table: dados_responsavel_familiar
CREATE TABLE dados_responsavel_familiar ( 
    nome                        VARCHAR( 255 ),
    sexo                        VARCHAR( 255 ),
    nascimento                  VARCHAR( 255 ),
    estado_civil                VARCHAR( 255 ),
    regime_casamento            VARCHAR( 255 ),
    uniao_consencual            BOOLEAN,
    frequenta_escola            BOOLEAN,
    escolaridade                VARCHAR( 255 ),
    beneficiario                BOOLEAN,
    programa_social             VARCHAR( 255 ),
    valor_beneficio             VARCHAR( 255 ),
    profissao                   VARCHAR,
    renda_cidadao               VARCHAR( 255 ),
    particularidade_deficiencia VARCHAR( 255 ),
    possui_laudo_med            BOOLEAN,
    possui_numero_cid           BOOLEAN,
    cpf                         VARCHAR( 255 ),
    rg_rne                      VARCHAR( 255 ),
    id                          INTEGER         PRIMARY KEY AUTOINCREMENT
                                                DEFAULT ( 0 ) 
                                                REFERENCES identificacao ( id ) ON DELETE CASCADE
                                                                                ON UPDATE CASCADE
                                                                                MATCH FULL,
    naturalidade                VARCHAR( 255 ),
    org_expedidor_cpf           VARCHAR( 255 ),
    data_expedicao_cpf          VARCHAR( 255 ),
    nome_mae                    VARCHAR( 255 ),
    nome_pai                    VARCHAR( 255 ) 
);

INSERT INTO [dados_responsavel_familiar] ([nome], [sexo], [nascimento], [estado_civil], [regime_casamento], [uniao_consencual], [frequenta_escola], [escolaridade], [beneficiario], [programa_social], [valor_beneficio], [profissao], [renda_cidadao], [particularidade_deficiencia], [possui_laudo_med], [possui_numero_cid], [cpf], [rg_rne], [id], [naturalidade], [org_expedidor_cpf], [data_expedicao_cpf], [nome_mae], [nome_pai]) VALUES ('Alvaro Paçó', 'Masc', '20/12/1987', '', '', 'False', 'False', '', 'False', '', '', '', '', '', 'False', 'False', '368,666,748-75', 437082441, 5, 'brasileiro', 'SSP', '  /  /', '', 'System.Windows.Forms.TextBox, Text: ');
