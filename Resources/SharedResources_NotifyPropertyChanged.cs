using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Resources;
using System.ComponentModel;
using System.Threading;

namespace CBT.DataAnnotations.Resources;

public partial class SharedResources : INotifyPropertyChanged
{
    public static SharedResources Resources = new ();

    public static void ChangeLanguage(string language)
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

        Resources.PropertyChanged?.Invoke(Resources, new PropertyChangedEventArgs(""));
        Resources.PropertyChanged?.Invoke(Resources, new PropertyChangedEventArgs("Item"));
        Resources.PropertyChanged?.Invoke(Resources, new PropertyChangedEventArgs("Item[]"));
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
