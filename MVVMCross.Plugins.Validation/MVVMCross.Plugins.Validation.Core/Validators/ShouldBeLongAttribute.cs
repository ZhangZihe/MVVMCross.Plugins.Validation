using System;

namespace MvvmCross.Plugins.Validation
{
    public class ShouldBeLongAttribute : ValidationAttribute
    {
        public ShouldBeLongAttribute(string message = null)
            : base(message)
        {
        }

        public override IValidation CreateValidation(Type valueType)
        {
            return new ShouldBeLongValidation(Message);
        }
    }
}