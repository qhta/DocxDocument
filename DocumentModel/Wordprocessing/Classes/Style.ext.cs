using System.ComponentModel;

using DocumentModel.UI;

namespace DocumentModel.Wordprocessing;

public partial class Style : INotifyPropertyChanged, INotifyPropertyChanging, INamedObject, IAliasedObject
{
  private ListOf<String>? _Aliases;

  /// <summary>
  ///   Primary Style Name.
  /// </summary>
  public String? Name
  {
    get => StyleName;
    set
    {
      if (StyleName != value)
      {
        NotifyPropertyChanging(nameof(Name));
        StyleName = value;
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

  public static string CreateStyleId(string name)
  {
    var chars = new List<char>();
    foreach (var ch in name)
      if (ch>='a' && ch<='z' || ch>='A' && ch<='Z' || ch>='0' && ch<='9')
        chars.Add(ch);
    return new string(chars.ToArray());
  }

  IEnumerable<string>? IAliasedObject.Aliases => Aliases;

  public bool IsDefined =>
    StyleParagraphProperties != null ||
    StyleRunProperties != null ||
    StyleTableProperties != null ||
    StyleTableCellProperties != null ||
    TableStyleConditionalFormattingTableRowProperties != null ||
    TableStyleProperties != null ||
    (this.Type == StyleKind.Numbering) && IsCustom == true && BasedOn != null;

  public bool IsValid {
    get
    {
      if (IsCustom == true && BasedOn != null)
        return true;
      if (IsDefault == true)
        return true;
      return  (this.Type == StyleKind.Paragraph) ? StyleParagraphProperties != null || StyleRunProperties != null :
              (this.Type == StyleKind.Character) ? StyleRunProperties != null :
              (this.Type == StyleKind.Table) ? StyleTableProperties != null ||
                                               StyleTableCellProperties != null ||
                                               TableStyleConditionalFormattingTableRowProperties != null ||
                                               TableStyleProperties != null :
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