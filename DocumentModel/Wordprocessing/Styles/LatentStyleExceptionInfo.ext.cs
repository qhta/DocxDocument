using System.ComponentModel;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial class LatentStyleExceptionInfo: INotifyPropertyChanged, INotifyPropertyChanging
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