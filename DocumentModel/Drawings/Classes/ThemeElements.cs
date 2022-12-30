namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ThemeElements Class.
/// </summary>
public partial class ThemeElements
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public DocumentModel.Drawings.ColorScheme? ColorScheme { get; set; }
  
  /// <summary>
  /// Font Scheme.
  /// </summary>
  public DocumentModel.Drawings.FontScheme? FontScheme { get; set; }
  
  /// <summary>
  /// Format Scheme.
  /// </summary>
  public DocumentModel.Drawings.FormatScheme? FormatScheme { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
