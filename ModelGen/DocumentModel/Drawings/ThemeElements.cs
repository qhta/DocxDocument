namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the theme formatting options for the theme and is the workhorse of the theme.  This is where the bulk of the shared theme information is contained and used by a document.  This element contains the color scheme, font scheme, and format scheme elements which define the different formatting aspects of what a theme defines.
/// </summary>
public partial class ThemeElements
{
  
  /// <summary>
  ///   ColorScheme.
  /// </summary>
  public DocumentModel.Drawings.ColorScheme? ColorScheme { get; set; }
  
  
  /// <summary>
  ///   Font Scheme.
  /// </summary>
  public DocumentModel.Drawings.FontScheme? FontScheme { get; set; }
  
  
  /// <summary>
  ///   Format Scheme.
  /// </summary>
  public DocumentModel.Drawings.FormatScheme? FormatScheme { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
