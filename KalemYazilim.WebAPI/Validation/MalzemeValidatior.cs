using FluentValidation;
using KalemYazilim.WebAPI.Model;

namespace KalemYazilim.WebAPI.Validation
{
    public class MalzemeValidatior:AbstractValidator<Malzeme>
    {
        public MalzemeValidatior()
        {
            RuleFor(x => x.UrunAdi).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.UrunAdi).MinimumLength(2).WithMessage("Minimum 2 karakter olmalidir");
            RuleFor(x => x.UrunAdi).MaximumLength(25).WithMessage("Maksimum 25 karakter olmalidir");


            RuleFor(x => x.UrunMarkasi).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.UrunMarkasi).MinimumLength(2).WithMessage("Minimum 2 karakter olmalidir");
            RuleFor(x => x.UrunMarkasi).MaximumLength(25).WithMessage("Maksimum 25 karakter olmalidir");

        }
    }
}
