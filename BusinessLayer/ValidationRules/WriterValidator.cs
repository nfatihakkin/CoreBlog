using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar İsim Soyismi boş geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Yazar maili boş geçilemez.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En az 2 karakter !");
            RuleFor(x => x.WriterName).MaximumLength(30).WithMessage("En fazla 30 karakter !");


        }
    }
}
