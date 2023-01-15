using System.ComponentModel;

namespace DocumentModel.Wordprocessing;

public partial class Style : INotifyPropertyChanged, INotifyPropertyChanging
{
  private ListOf<String>? _Aliases;

  private String? _StyleName;

  /// <summary>
  ///   Primary Style Name.
  /// </summary>
  public String? StyleName
  {
    get => _StyleName;
    set
    {
      if (_StyleName != value)
      {
        NotifyPropertyChanging(nameof(StyleName));
        _StyleName = value;
        NotifyPropertyChanged(nameof(StyleName));
      }
    }
  }

  /// <summary>
  ///   Alternate Style Names.
  /// </summary>
  public ListOf<String>? Aliases
  {
    get => _Aliases;
    set
    {
      if (_Aliases != value)
      {
        NotifyPropertyChanging(nameof(Aliases));
        _Aliases = value;
        NotifyPropertyChanged(nameof(Aliases));
      }
    }
  }

  public event PropertyChangedEventHandler? PropertyChanged;
  public event PropertyChangingEventHandler? PropertyChanging;

  public void NotifyPropertyChanging(string propertyName)
  {
    PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
  }

  public void NotifyPropertyChanged(string propertyName)
  {
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }
}