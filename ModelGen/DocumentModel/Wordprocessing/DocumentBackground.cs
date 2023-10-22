namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the background for every page of the document containing the background element. A document's background is the image or fill for the entire page surface, behind all other document content.
/// </summary>
public partial class DocumentBackground
{
  
  /// <summary>
  ///   color
  /// </summary>
  public String? Color { get; set; }
  
  
  /// <summary>
  ///   themeTint
  /// </summary>
  public String? ThemeTint { get; set; }
  
  
  /// <summary>
  ///   themeShade
  /// </summary>
  public String? ThemeShade { get; set; }
  
  
  /// <summary>
  ///   Background.
  /// </summary>
  public DocumentModel.Vml.Background? Background { get; set; }
  
}
