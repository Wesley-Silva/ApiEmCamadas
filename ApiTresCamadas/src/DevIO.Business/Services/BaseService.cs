using DevIO.Business.Models;
using DevIO.Business.Validation.Documentos.Dev.Business.Models.Base.Validations.Documentos;
using FluentValidation;

namespace DevIO.Business.Services
{
    public abstract class BaseService
    {
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) 
            where TV : AbstractValidator<TE>
            where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid)
            {
                return true;
            }

            // Lançamento de notificações

            return false;
        }
    }
}
