namespace DocxDocument.Model;

public class Theme: Collection<ThemeElement>
{
  [XmlIgnore]
  [JsonIgnore]
  public Document? Document
  {
    get => _Document;
    set
    {
      if (_Document != value)
      {
        _Document = value;
        //if (DefaultRunProperties != null)
        //  DefaultRunProperties.Document = value;
      }
    }
  }
  private Document? _Document;

  /// <summary> 
  /// Identifier in Office 2013
  ///</summary> 
  [XmlAttribute]
  public string? ThemeId { get; set; }

  /// <summary> 
  /// Visible name
  ///</summary> 
  [XmlAttribute]
  public String? Name { get; set; }

  //  /// <summary> 
  //  /// Custom Color List
  //  ///</summary> 
  //  public CustomColorList? CustomColorList { get; set; }

  //  /// <summary> 
  //  /// Extra Color Scheme List.
  //  ///</summary> 
  //  public ExtraColorSchemeList? ExtraColorSchemeList { get; set; }

  //  /// <summary> 
  //  /// Object Defaults.
  //  ///</summary> 
  //  public ObjectDefaults? ObjectDefaults{ get; set; }

  ///// <summary> 
  ///// Office Style Sheet Extension Lists
  /////</summary> 
  //public OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionLists { get; set; }

}