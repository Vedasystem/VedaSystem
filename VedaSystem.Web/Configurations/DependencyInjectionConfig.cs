using Microsoft.Extensions.DependencyInjection;
using System;
using VedaSystem.Application.Interfaces;
using VedaSystem.Application.Services;
using VedaSystem.Domain.Interfaces;
using VedaSystem.Infra.Data.Repositorys;
using VedaSystem.Web.Interface;
using VedaSystem.Web.Utils;

namespace VedaSystem.Web.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            #region Services
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<ILogService, LogService>();
            services.AddTransient<IPacienteService, PacienteService>();
            services.AddTransient<IAgendaService, AgendaService>();
            services.AddTransient<IHorarioService, HorarioService>();
            services.AddTransient<IMaterialTerapiaService, MaterialTerapiaService>();
            services.AddTransient<IMedicamentoService, MedicamentoService>();
            services.AddTransient<IPrescricaoService, PrescricaoService>();
            services.AddTransient<ITerapeutaService, TerapeutaService>();
            services.AddTransient<ITerapiaService, TerapiaService>();
            services.AddTransient<ITradutorService, TradutorService>();
            services.AddTransient<ITransmissaoService, TransmissaoService>();
            services.AddTransient<IEstoqueMaterialService, EstoqueMaterialService>();
            services.AddTransient<ITratamentoService, TratamentoService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IDepoimentoService, DepoimentoService>();
            services.AddTransient<IFichaClinicaPacienteService, FichaClinicaPacienteService>();
            services.AddTransient<IQuestionarioPosDiagnosticoService, QuestionarioPosDiagnosticoService>();



            #endregion

            #region Repositories
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<ILogRepository, LogRepository>();
            services.AddTransient<IPacienteRepository, PacienteRepository>();
            services.AddTransient<IAgendaRepository, AgendaRepository>();
            services.AddTransient<IHorarioRepository, HorarioRepository>();
            services.AddTransient<IMaterialTerapiaRepository, MaterialTerapiaRepository>();
            services.AddTransient<IMedicamentoRepository, MedicamentoRepository>();
            services.AddTransient<IPrescricaoRepository, PrescricaoRepository>();
            services.AddTransient<ITerapeutaRepository, TerapeutaRepository>();
            services.AddTransient<ITerapiaRepository, TerapiaRepository>();
            services.AddTransient<ITradutorRepository, TradutorRepository>();
            services.AddTransient<ITransmissaoRepository, TransmissaoRepository>();
            services.AddTransient<IEstoqueMaterialRepository, EstoqueMaterialRepository>();
            services.AddTransient<ITratamentoRepository, TratamentoRepository>();
            services.AddTransient<IEmailRepository, EmailRepository>();
            services.AddTransient<IDepoimentoRepository, DepoimentoRepository>();
            services.AddTransient<IFichaClinicaPacienteRepository, FichaClinicaPacienteRepository>();
            services.AddTransient<IQuestionarioPosDiagnosticoRepository, QuestionarioPosDiagnosticoRepository>();


            #endregion

            #region Others
            services.AddTransient<IUser, AspNetUser>();
            #endregion
        }
    }
}
