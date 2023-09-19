namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the background for every page of the document containing the background element. A document's background is the image or fill for the entire page surface, behind all other document content.
/// </summary>
public partial class DocumentBackground
{
  
  /// <summary>
  ///   color
  /// </summary>
  [SchemaAttr("w:color")]
  public String? Color { get; set; }
  
  
  /// <summary>
  ///   themeColor
  /// </summary>
  [SchemaAttr("w:themeColor")]
  public DocumentModel.Wordprocessing.ThemeColorValues? ThemeColor { get; set; }
  
  
  /// <summary>
  ///   themeTint
  /// </summary>
  [SchemaAttr("w:themeTint")]
  public String? ThemeTint { get; set; }
  
  
  /// <summary>
  ///   themeShade
  /// </summary>
  [SchemaAttr("w:themeShade")]
  public String? ThemeShade { get; set; }
  
  
  /// <summary>
  ///   Background.
  /// </summary>
  public DocumentModel.Vml.Background? Background { get; set; }
  
}
