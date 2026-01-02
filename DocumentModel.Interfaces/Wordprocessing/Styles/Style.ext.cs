namespace DocumentModel.Wordprocessing;
public partial class Style : INotifyPropertyChanged, INotifyPropertyChanging, INamedObject, IAliasedObject
{
  /// <summary>
  ///   Primary Style Name.
  /// </summary>
  public string? Name
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
  ///   Specifies the set of alternative names for the parent style definition. 
  ///   These names can be used in an application's user interface as desired. 
  ///   Each name shall be separated by one or more consecutive comma characters (Unicode character value 002C). 
  ///   All commas present shall be interpreted as separator character and never as part of an alternate style name.
  /// </summary>
  public IStringList? Aliases
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
  private IStringList? _Aliases;

  /// <summary>
  /// Creates styleId from style name. Only ASCII letters and digits are accepted.
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  public static string CreateStyleId(string name)
  {
    var chars = new List<char>();
    foreach (var ch in name)
      if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch >= '0' && ch <= '9')
        chars.Add(ch);
    return new string(chars.ToArray());
  }
  IEnumerable<string>? IAliasedObject.Aliases => Aliases;
  /// <summary>
  /// Determines whether any properties are defined.
  /// </summary>
  public bool IsDefined =>
    StyleParagraphProperties != null ||
    StyleRunProperties != null ||
    StyleTableProperties != null ||
    StyleTableCellProperties != null ||
    TableStyleConditionalFormattingTableRowProperties != null ||
    TableStyleConditionalProperties != null ||
    (this.Type == StyleKind.Numbering) && IsCustom == true && BasedOn != null;
  /// <summary>
  /// Determines whether suitable properties are defined for specific style types.
  /// </summary>
  public bool IsVl
  {
    get
    {
      if (IsCustom == true && BasedOn != null)
        return true;
      if (IsDefault == true)
        return true;
      return (this.Type == StyleKind.Paragraph) ? StyleParagraphProperties != null || StyleRunProperties != null :
              (this.Type == StyleKind.Character) ? StyleRunProperties != null :
              (this.Type == StyleKind.Table) ? StyleTableProperties != null ||
                                               StyleTableCellProperties != null ||
                                               TableStyleConditionalFormattingTableRowProperties != null ||
                                               TableStyleConditionalProperties != null :
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