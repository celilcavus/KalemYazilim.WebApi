using FluentValidation;
using KalemYazilim.WebAPI.Model;

namespace KalemYazilim.WebAPI.Validation
{
    public class SatisFaturasiValidatior:AbstractValidator<SatisFaturasi>
    {
        public SatisFaturasiValidatior()
        {
            RuleFor(x => x.BelgeNo).NotEmpty().WithMessage("Boş Bırakılamaz");
            RuleFor(x => x.MusteriId).NotEmpty().WithMessage("Boş Bırakılamaz");

        }
    }
}
