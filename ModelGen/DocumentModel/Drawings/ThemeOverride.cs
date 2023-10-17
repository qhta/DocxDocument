namespace DocumentModel.Drawings;


/// <summary>
///   This element allows for an override which changes just the colors, fonts, or effects of a single object, like a table for example.  Currently it is used only to control overrides on the non-top-level masters within a presentation.
/// </summary>
public partial class ThemeOverride
{
  
  /// <summary>
  ///   Color Scheme.
  /// </summary>
  public DocumentModel.Drawings.ColorScheme? ColorScheme { get; set; }
  
  
  /// <summary>
  ///   FontScheme.
  /// </summary>
  public DocumentModel.Drawings.FontScheme? FontScheme { get; set; }
  
  
  /// <summary>
  ///   FormatScheme.
  /// </summary>
  public DocumentModel.Drawings.FormatScheme? FormatScheme { get; set; }
  
}
