using FluentValidation;
using KalemYazilim.WebAPI.Model;

namespace KalemYazilim.WebAPI.Validation
{
    public class SatisFaturasiSatiriValidatior:AbstractValidator<SatisFaturaSatiri>
    {
        public SatisFaturasiSatiriValidatior()
        {
            RuleFor(x => x.SatirNo).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.SatisFaturasiId).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.MalzemeId).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.Birim).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.Miktar).NotEmpty().WithMessage("Boş Bırakılamaz");
        }
    }
}
