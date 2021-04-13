using System.Runtime.CompilerServices;

namespace Rhinoceros.MVVM
{
    public class BaseModelWithIsModify : BaseModel
    {
        protected virtual bool IsModify { get; set; }

        public bool SetPropertyWithFlag<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (SetProperty(ref field, value, propertyName))
            {
                IsModify = true;
                return true;
            }

            return false;
        }
    }
}