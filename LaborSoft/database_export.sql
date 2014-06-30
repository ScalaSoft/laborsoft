
-- Table: identificacao
CREATE TABLE identificacao ( 
    id                     INTEGER         PRIMARY KEY AUTOINCREMENT
                                           NOT NULL
                                           DEFAULT ( 0 ),
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
    nome_entrevistado      VARCHAR( 255 ) 
);


-- Table: dados_entrevista
CREATE TABLE dados_entrevista ( 
    entrevistador       VARCHAR,
    data_entrevista     VARCHAR,
    supervisor          VARCHAR,
    data_supervisao     VARCHAR,
    condicao_entrevista VARCHAR,
    outra_condicao      VARCHAR,
    id                  INTEGER PRIMARY KEY AUTOINCREMENT
                                DEFAULT ( 0 ) 
                                REFERENCES identificacao ( id ) ON DELETE CASCADE
                                                                ON UPDATE CASCADE
                                                                MATCH FULL 
);


-- Table: participacao_organizacao
CREATE TABLE participacao_organizacao ( 
    assoc_conhece           BOOLEAN,
    qual_assoc              VARCHAR,
    participa_assoc         BOOLEAN,
    em_qual_participa       VARCHAR,
    razao_de_nao_participar VARCHAR,
    liderancas_area         VARCHAR,
    id                      INTEGER PRIMARY KEY AUTOINCREMENT
                                    DEFAULT ( 0 ) 
                                    REFERENCES identificacao ( id ) ON DELETE CASCADE
                                                                    ON UPDATE CASCADE
                                                                    MATCH FULL 
);


-- Table: dados_responsavel_familiar
CREATE TABLE dados_responsavel_familiar ( 
    id                          INTEGER         PRIMARY KEY AUTOINCREMENT
                                                DEFAULT ( 0 ) 
                                                REFERENCES identificacao ( id ) ON DELETE CASCADE
                                                                                ON UPDATE CASCADE
                                                                                MATCH FULL,
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
    naturalidade                VARCHAR( 255 ),
    org_expedidor_cpf           VARCHAR( 255 ),
    data_expedicao_cpf          VARCHAR( 255 ),
    nome_mae                    VARCHAR( 255 ),
    nome_pai                    VARCHAR( 255 ) 
);


-- Table: dados_conjuge
CREATE TABLE dados_conjuge ( 
    id                          INTEGER         PRIMARY KEY AUTOINCREMENT
                                                DEFAULT ( 0 ) 
                                                REFERENCES identificacao ( id ) ON DELETE CASCADE
                                                                                ON UPDATE CASCADE
                                                                                MATCH FULL,
    nome                        VARCHAR( 255 ),
    relacao_resp_fam            VARCHAR( 255 ),
    sexo                        VARCHAR( 255 ),
    nascimento                  VARCHAR( 255 ),
    naturalidade                VARCHAR( 255 ),
    uf                          VARCHAR,
    cpf                         VARCHAR( 255 ),
    org_expedidor_cpf           VARCHAR,
    rg_rne                      VARCHAR( 255 ),
    org_exp_cpf                 VARCHAR( 255 ),
    data_expedicao_cpf          VARCHAR,
    data_exp_cpf                VARCHAR( 255 ),
    estado_civil                VARCHAR( 255 ),
    regime_casamento            VARCHAR( 255 ),
    uniao_consensual            BOOLEAN,
    frequentou_escola           BOOLEAN,
    escolaridade                VARCHAR( 255 ),
    alfabetizado_rg             BOOLEAN,
    assina_nome                 BOOLEAN,
    profissao                   VARCHAR( 255 ),
    renda                       VARCHAR( 255 ),
    beneficiario_prog_soc       BOOLEAN,
    prog_soc_qual               VARCHAR( 255 ),
    valor_beneficio             VARCHAR( 255 ),
    particularidade_deficiencia VARCHAR( 255 ),
    possui_laudo_medico         BOOLEAN,
    possui_cid                  BOOLEAN,
    nome_mae                    VARCHAR( 255 ),
    nome_pai                    VARCHAR( 255 ) 
);


-- Table: composicao_familiar
CREATE TABLE composicao_familiar ( 
    id                            INTEGER         PRIMARY KEY AUTOINCREMENT
                                                  DEFAULT ( 0 ) 
                                                  REFERENCES identificacao ( id ) ON DELETE CASCADE
                                                                                  ON UPDATE CASCADE
                                                                                  MATCH FULL,
    nome_1                        VARCHAR( 255 ),
    relacao_resp_fam_1            VARCHAR( 255 ),
    sexo_1                        VARCHAR( 255 ),
    nascimento_1                  VARCHAR( 255 ),
    estado_civil_1                VARCHAR( 255 ),
    regime_casamento_1            VARCHAR( 255 ),
    uniao_consensual_1            BOOLEAN,
    frequentou_escola_1           BOOLEAN,
    escolaridade_1                VARCHAR( 255 ),
    profissao_1                   VARCHAR( 255 ),
    renda_1                       VARCHAR( 255 ),
    beneficiario_prog_soc_1       BOOLEAN,
    prog_soc_qual_1               VARCHAR( 255 ),
    valor_beneficio_1             VARCHAR( 255 ),
    particularidade_deficiencia_1 VARCHAR( 255 ),
    possui_laudo_medico_1         BOOLEAN,
    possui_cid_1                  BOOLEAN,
    nome_2                        VARCHAR( 255 ),
    relacao_resp_fam_2            VARCHAR( 255 ),
    sexo_2                        VARCHAR( 255 ),
    nascimento_2                  VARCHAR( 255 ),
    estado_civil_2                VARCHAR( 255 ),
    regime_casamento_2            VARCHAR( 255 ),
    uniao_consensual_2            BOOLEAN,
    frequentou_escola_2           BOOLEAN,
    escolaridade_2                VARCHAR( 255 ),
    profissao_2                   VARCHAR( 255 ),
    renda_2                       VARCHAR( 255 ),
    beneficiario_prog_soc_2       BOOLEAN,
    prog_soc_qual_2               VARCHAR( 255 ),
    valor_beneficio_2             VARCHAR( 255 ),
    particularidade_deficiencia_2 VARCHAR( 255 ),
    possui_laudo_medico_2         BOOLEAN,
    possui_cid_2                  BOOLEAN,
    nome_3                        VARCHAR( 255 ),
    relacao_resp_fam_3            VARCHAR( 255 ),
    sexo_3                        VARCHAR( 255 ),
    nascimento_3                  VARCHAR( 255 ),
    estado_civil_3                VARCHAR( 255 ),
    regime_casamento_3            VARCHAR( 255 ),
    uniao_consensual_3            BOOLEAN,
    frequentou_escola_3           BOOLEAN,
    escolaridade_3                VARCHAR( 255 ),
    profissao_3                   VARCHAR( 255 ),
    renda_3                       VARCHAR( 255 ),
    beneficiario_prog_soc_3       BOOLEAN,
    prog_soc_qual_3               VARCHAR( 255 ),
    valor_beneficio_3             VARCHAR( 255 ),
    particularidade_deficiencia_3 VARCHAR( 255 ),
    possui_laudo_medico_3         BOOLEAN,
    possui_cid_3                  BOOLEAN 
);


-- Table: uso_ocupacao_domicilio
CREATE TABLE uso_ocupacao_domicilio ( 
    id                   INTEGER PRIMARY KEY AUTOINCREMENT
                                 DEFAULT ( 0 ) 
                                 REFERENCES identificacao ( id ) ON DELETE CASCADE
                                                                 ON UPDATE CASCADE
                                                                 MATCH FULL,
    situacao             VARCHAR,
    situacao_de_risco    BOOLEAN,
    padrao_edificao      VARCHAR,
    tipo_ocupacao        VARCHAR,
    valor_do_aluguel     VARCHAR,
    tipo_uso_imovel      VARCHAR,
    qual_atividade       VARCHAR,
    banheiro             BOOLEAN,
    area_terreno         VARCHAR,
    possui_outro_imovel  BOOLEAN,
    outro_imovel_onde    VARCHAR,
    tempo_no_domicilio   VARCHAR,
    doc_prefeitura       BOOLEAN,
    doc_temp_moradia     BOOLEAN,
    quais_docs           VARCHAR,
    tempo_mora_area      VARCHAR,
    morava_onde_antes    VARCHAR,
    tempo_mora_municipio VARCHAR,
    municipio_anterior   VARCHAR,
    psh                  BOOLEAN,
    ano_psh              NUMERIC,
    possui_iptu          BOOLEAN 
);


-- Table: dados_de_contato
CREATE TABLE dados_de_contato ( 
    tel_residencial   VARCHAR,
    tel_celular       VARCHAR,
    tel_comercial     VARCHAR,
    tel_recado        VARCHAR,
    logradouro        VARCHAR,
    numero_logradouro NUMERIC,
    complemento       VARCHAR,
    bairro            VARCHAR,
    cep               VARCHAR,
    id                INTEGER PRIMARY KEY AUTOINCREMENT
                              DEFAULT ( 0 ) 
                              REFERENCES identificacao ( id ) ON DELETE CASCADE
                                                              ON UPDATE CASCADE
                                                              MATCH FULL 
);

