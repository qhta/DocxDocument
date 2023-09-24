namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the root level complex type associated with a shared style sheet (or theme).  This element holds all the different formatting options available to a document through a theme and defines the overall look and feel of the document when themed objects are used within the document.
/// </summary>
public partial class Theme
{
  
  /// <summary>
  ///   Specifies the name given to the theme.
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2013 and later.
  /// </summary>
  public HexInt? ThemeId { get; set; }
  
  
  /// <summary>
  ///   ThemeElements.
  /// </summary>
  public ThemeElements? ThemeElements { get; set; }
  
  
  /// <summary>
  ///   ObjectDefaults.
  /// </summary>
  public ObjectDefaults? ObjectDefaults { get; set; }
  
  
  /// <summary>
  ///   ExtraColorSchemeList.
  /// </summary>
  public ExtraColorSchemeList? ExtraColorSchemeList { get; set; }
  
  
  /// <summary>
  ///   CustomColorList.
  /// </summary>
  public CustomColorList? CustomColorList { get; set; }
  
  
  /// <summary>
  ///   OfficeStyleSheetExtensionList.
  /// </summary>
  public OfficeStyleSheetExtensionList? OfficeStyleSheetExtensionList { get; set; }
  
}
