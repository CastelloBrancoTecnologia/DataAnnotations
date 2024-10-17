using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;
using System.ComponentModel;
using System.Threading;

namespace CastelloBranco.DataAnnotations.Resources;

public partial class SharedResources : INotifyPropertyChanged
{
    public void ChangeLanguage(string language)
    {
        Thread.CurrentThread.CurrentCulture   = 
          Thread.CurrentThread.CurrentUICulture = 
          resourceCulture = new CultureInfo(language);

        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));       
    }

    public string? this[string key]
    {
        get
        {
            return ResourceManager.GetString(key, Thread.CurrentThread.CurrentUICulture);
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
