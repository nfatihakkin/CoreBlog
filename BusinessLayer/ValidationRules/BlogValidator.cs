using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş bırakmayınız.");
            RuleFor(x => x.BlogTitle).MinimumLength(2).WithMessage("En az 2 karakter giriniz.");
            RuleFor(x => x.BlogTitle).MaximumLength(50).WithMessage("En fazla 50 karakter giriniz.");

            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog başlığını boş bırakmayınız.");
            RuleFor(x => x.BlogContent).MinimumLength(20).WithMessage("En az 20 karakter giriniz.");

            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini ekleyiniz.");
            
           
        }

    }
}
