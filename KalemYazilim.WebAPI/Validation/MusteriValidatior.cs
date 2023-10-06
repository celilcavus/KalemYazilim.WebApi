using FluentValidation;
using KalemYazilim.WebAPI.Model;

namespace KalemYazilim.WebAPI.Validatiors
{
    public class MusteriValidatior:AbstractValidator<Musteri>
    {
        public MusteriValidatior()
        {
            RuleFor(x => x.Ad).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.Ad).MinimumLength(2).WithMessage("Minimum 2 karakter olmalidir");
            RuleFor(x => x.Ad).MaximumLength(25).WithMessage("Maksimum 25 karakter olmalidir");

            RuleFor(x => x.Soyad).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.Soyad).MinimumLength(2).WithMessage("Minimum 2 karakter olmalidir");
            RuleFor(x => x.Soyad).MaximumLength(25).WithMessage("Maksimum 25 karakter olmalidir");

            RuleFor(x => x.VKN).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.VKN).Length(11).WithMessage("Maksimum 11 karakter olmalidir");

            RuleFor(x => x.TCKN).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.TCKN).Length(11).WithMessage("Minimum 11 karakter olmalidir");


        }
    }
}
