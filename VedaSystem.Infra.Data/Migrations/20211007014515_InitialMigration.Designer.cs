// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VedaSystem.Infra.Data.Context;

namespace VedaSystem.Infra.Data.Migrations
{
    [DbContext(typeof(TerapeutaContext))]
    [Migration("20211007014515_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MedicamentoPrescricao", b =>
                {
                    b.Property<Guid>("MedicamentosId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PrescricoesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MedicamentosId", "PrescricoesId");

                    b.HasIndex("PrescricoesId");

                    b.ToTable("MedicamentoPrescricao");
                });

            modelBuilder.Entity("PacienteTerapeuta", b =>
                {
                    b.Property<Guid>("PacientesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TerapeutasId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PacientesId", "TerapeutasId");

                    b.HasIndex("TerapeutasId");

                    b.ToTable("PacienteTerapeuta");
                });

            modelBuilder.Entity("TerapeutaTerapia", b =>
                {
                    b.Property<Guid>("TerapeutasId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TerapiasId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TerapeutasId", "TerapiasId");

                    b.HasIndex("TerapiasId");

                    b.ToTable("TerapeutaTerapia");
                });

            modelBuilder.Entity("TerapeutaTerapiaPrincipal", b =>
                {
                    b.Property<Guid>("TerapeutasId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TerapiasPrincipaisId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("TerapeutasId", "TerapiasPrincipaisId");

                    b.HasIndex("TerapiasPrincipaisId");

                    b.ToTable("TerapeutaTerapiaPrincipal");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Agenda", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("DiaMes")
                        .HasColumnType("int");

                    b.Property<int>("DiaSemana")
                        .HasColumnType("int");

                    b.Property<int>("Mes")
                        .HasColumnType("int");

                    b.Property<Guid?>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TerapeutaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TerapiaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TerapiaPrincipalId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.HasIndex("TerapeutaId");

                    b.HasIndex("TerapiaId");

                    b.HasIndex("TerapiaPrincipalId");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeliveryMethod")
                        .HasColumnType("int");

                    b.Property<string>("EmailAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EnableSsl")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBodyHtml")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Port")
                        .HasColumnType("int");

                    b.Property<string>("Smtp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TerapeutaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("To")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UseDefaultCredentials")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("TerapeutaId")
                        .IsUnique();

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.FichaClinicaPaciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AcordaANoiteQuantasVezesPorQue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlgumDisturbio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AlgumOutroDadoImportante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Apetite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AspectoFisico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CaracteristicasLingua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CaracteristicasUnhas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheiroFezes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheiroSuor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheiroUrina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComoEOSono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConsistenciaFezes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConsistenciaSuor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorFezes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CorUrina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DesconfortoEliminacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoCivil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FazUsoDeAlgumaSubstânciaViciante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fluxo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraQueAcorda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraQueDorme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorariosDasRefeicoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotivoFome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OQueComeACadaRefeicao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OQueFazACadaHoraDoDia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OqueFazAoAcordar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Palpacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PioramOuMelhoram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profissao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PulsoVikriti")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QtdFezes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QtdHorasPorDia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QtdSuor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QtdUrina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuixasPrincipais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regularidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegularidadeDuracaoDoCiclo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeSenteBemAoAcordar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeSenteBemAoLongoDoDia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeSenteRestauradoPelaManha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenteDisposicaoSeExercitar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenteQueDormeBem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sintomas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SonhaComoSaoOsSonhos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempoFomeNovamente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TempoSintomas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TerapeutaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TipoExercicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TomaAlgumMedicamento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.HasIndex("TerapeutaId");

                    b.ToTable("FichaClinicaPaciente");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Horario", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("Dia")
                        .HasColumnType("int");

                    b.Property<int>("DuracaoConsultaEmMinutos")
                        .HasColumnType("int");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("Intervalo")
                        .HasColumnType("int");

                    b.Property<int>("Mes")
                        .HasColumnType("int");

                    b.Property<bool>("Reservado")
                        .HasColumnType("bit");

                    b.Property<Guid>("TerapeutaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TerapiaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TerapeutaId");

                    b.ToTable("Horarios");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.MaterialTerapia", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<Guid?>("EstoqueMaterialId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<Guid?>("TerapiaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TerapiaId");

                    b.ToTable("MaterialTerapias");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Medicamento", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Composicao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Laboratorio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoMedicamento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Paciente", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Altura")
                        .HasColumnType("real");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotivoConsulta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Peso")
                        .HasColumnType("real");

                    b.Property<string>("RedeSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Prescricao", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataDaPrescricao")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TerapeutaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ValidadeDaPrescricao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.HasIndex("TerapeutaId");

                    b.ToTable("Prescricoes");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.QuestionarioPosDiagnostico", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apetite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BeneficiosTratamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CaracteristicasFezes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CaracteristicasUrina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComentarioAdicional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Disposição")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PeriodoShamana")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QueixasPersistentes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeguiuAdequadamente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TerapeutaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.HasIndex("TerapeutaId");

                    b.ToTable("QuestionarioPosDiagnostico");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Terapeuta", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Apresentacao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CNPJ")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Celular")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ConfirmeSenha")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NomeDeUsuario")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Observacoes")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Site")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("TipoPessoa")
                        .HasColumnType("int");

                    b.Property<bool>("WhatsApp")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Terapeutas");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Terapia", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("Duracao")
                        .HasColumnType("time");

                    b.Property<string>("NomeTerapia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Terapias");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.TerapiaPrincipal", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan>("Duracao")
                        .HasColumnType("time");

                    b.Property<string>("NomeTerapia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TerapiaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("TerapiaPrincipais");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Transmissao", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("CodigoDeIncorporacaoDeVideo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdsDepoimentos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rodape")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TerapeutaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TextoAntesDoVideo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TextoDepoisDoVideo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TerapeutaId");

                    b.ToTable("Transmissoes");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Tratamento", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescricaoTratamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medicamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("MeidcamentoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Ordem")
                        .HasColumnType("int");

                    b.Property<Guid>("PrescricaoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PrescricaoId");

                    b.ToTable("Tratamentos");
                });

            modelBuilder.Entity("MedicamentoPrescricao", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Medicamento", null)
                        .WithMany()
                        .HasForeignKey("MedicamentosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VedaSystem.Domain.Models.Prescricao", null)
                        .WithMany()
                        .HasForeignKey("PrescricoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PacienteTerapeuta", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Paciente", null)
                        .WithMany()
                        .HasForeignKey("PacientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VedaSystem.Domain.Models.Terapeuta", null)
                        .WithMany()
                        .HasForeignKey("TerapeutasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TerapeutaTerapia", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Terapeuta", null)
                        .WithMany()
                        .HasForeignKey("TerapeutasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VedaSystem.Domain.Models.Terapia", null)
                        .WithMany()
                        .HasForeignKey("TerapiasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TerapeutaTerapiaPrincipal", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Terapeuta", null)
                        .WithMany()
                        .HasForeignKey("TerapeutasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VedaSystem.Domain.Models.TerapiaPrincipal", null)
                        .WithMany()
                        .HasForeignKey("TerapiasPrincipaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Agenda", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Paciente", "Paciente")
                        .WithMany("Agendas")
                        .HasForeignKey("PacienteId");

                    b.HasOne("VedaSystem.Domain.Models.Terapeuta", "Terapeuta")
                        .WithMany("Agendas")
                        .HasForeignKey("TerapeutaId");

                    b.HasOne("VedaSystem.Domain.Models.Terapia", "Terapia")
                        .WithMany("Agendas")
                        .HasForeignKey("TerapiaId");

                    b.HasOne("VedaSystem.Domain.Models.TerapiaPrincipal", null)
                        .WithMany("Agendas")
                        .HasForeignKey("TerapiaPrincipalId");

                    b.Navigation("Paciente");

                    b.Navigation("Terapeuta");

                    b.Navigation("Terapia");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Email", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Terapeuta", "Terapeuta")
                        .WithOne("EmailConfig")
                        .HasForeignKey("VedaSystem.Domain.Models.Email", "TerapeutaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Terapeuta");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.FichaClinicaPaciente", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Paciente", "Paciente")
                        .WithMany("FichasClinicas")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VedaSystem.Domain.Models.Terapeuta", "Terapeuta")
                        .WithMany("FichaClinicaPacientes")
                        .HasForeignKey("TerapeutaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");

                    b.Navigation("Terapeuta");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Horario", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Terapeuta", "Terapeuta")
                        .WithMany("Horarios")
                        .HasForeignKey("TerapeutaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Terapeuta");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.MaterialTerapia", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Terapia", "Terapia")
                        .WithMany("Materiais")
                        .HasForeignKey("TerapiaId");

                    b.Navigation("Terapia");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Prescricao", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Paciente", "Paciente")
                        .WithMany("Prescricoes")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VedaSystem.Domain.Models.Terapeuta", "Terapeuta")
                        .WithMany("Precricoes")
                        .HasForeignKey("TerapeutaId");

                    b.Navigation("Paciente");

                    b.Navigation("Terapeuta");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.QuestionarioPosDiagnostico", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Paciente", "Paciente")
                        .WithMany("QuestionariosPosDiagnosticos")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VedaSystem.Domain.Models.Terapeuta", "Terapeuta")
                        .WithMany("QuestionarioPosDiagnosticos")
                        .HasForeignKey("TerapeutaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");

                    b.Navigation("Terapeuta");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Transmissao", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Terapeuta", "Terapeuta")
                        .WithMany("Transmissoes")
                        .HasForeignKey("TerapeutaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Terapeuta");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Tratamento", b =>
                {
                    b.HasOne("VedaSystem.Domain.Models.Prescricao", "Prescricao")
                        .WithMany("Tratamentos")
                        .HasForeignKey("PrescricaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prescricao");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Paciente", b =>
                {
                    b.Navigation("Agendas");

                    b.Navigation("FichasClinicas");

                    b.Navigation("Prescricoes");

                    b.Navigation("QuestionariosPosDiagnosticos");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Prescricao", b =>
                {
                    b.Navigation("Tratamentos");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Terapeuta", b =>
                {
                    b.Navigation("Agendas");

                    b.Navigation("EmailConfig");

                    b.Navigation("FichaClinicaPacientes");

                    b.Navigation("Horarios");

                    b.Navigation("Precricoes");

                    b.Navigation("QuestionarioPosDiagnosticos");

                    b.Navigation("Transmissoes");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.Terapia", b =>
                {
                    b.Navigation("Agendas");

                    b.Navigation("Materiais");
                });

            modelBuilder.Entity("VedaSystem.Domain.Models.TerapiaPrincipal", b =>
                {
                    b.Navigation("Agendas");
                });
#pragma warning restore 612, 618
        }
    }
}
