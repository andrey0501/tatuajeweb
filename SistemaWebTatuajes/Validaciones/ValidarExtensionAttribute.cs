using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.Validaciones
{
    public class ValidarExtensionAttribute : ValidationAttribute
    {
        private readonly string[] TipoValidos;

        public ValidarExtensionAttribute(string[] tipoValidos)
        {
            TipoValidos = tipoValidos;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var formFile = value as IFormFile;
            if (formFile != null)
            {
                if (!TipoValidos.Contains(formFile.ContentType))
                {
                    return new ValidationResult($"Los tipos válidos son {string.Join(",", TipoValidos)}");
                }
            }
            return ValidationResult.Success;
        }
    }
}
