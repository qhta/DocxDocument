using System.ComponentModel;

using DocumentModel.UI;

namespace DocumentModel.Wordprocessing;

public partial class Style : INotifyPropertyChanged, INotifyPropertyChanging, INamedObject, IAliasedObject
{
  private ListOf<String>? _Aliases;

  private String? _StyleName;

  /// <summary>
  ///   Primary Style Name.
  /// </summary>
  public String? Name
  {
    get => _StyleName;
    set
    {
      if (_StyleName != value)
      {
        NotifyPropertyChanging(nameof(Name));
        _StyleName = value;
        NotifyPropertyChanged(nameof(Name));
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

  IEnumerable<string>? IAliasedObject.Aliases => Aliases;

  public bool IsDefined =>
    StyleParagraphProperties != null ||
    StyleRunProperties != null ||
    StyleTableProperties != null ||
    StyleTableCellProperties != null ||
    TableStyleConditionalFormattingTableRowProperties != null ||
    TableStylePropertieses != null ||
    (this.Type == StyleKind.Numbering) && IsCustom && BasedOn != null;

  public bool IsCustom
  {
    get => CustomStyle == true;
    set => CustomStyle = value;
  }

  public bool IsValid {
    get
    {
      if (IsCustom && BasedOn != null)
        return true;
      if (Default == true)
        return true;
      return  (this.Type == StyleKind.Paragraph) ? StyleParagraphProperties != null || StyleRunProperties != null :
              (this.Type == StyleKind.Character) ? StyleRunProperties != null :
              (this.Type == StyleKind.Table) ? StyleTableProperties != null ||
                                               StyleTableCellProperties != null ||
                                               TableStyleConditionalFormattingTableRowProperties != null ||
                                               TableStylePropertieses != null :
              (this.Type == StyleKind.Numbering);
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


  public override string ToString()
  {
    return $"{Name} ({Type})";
  }

}