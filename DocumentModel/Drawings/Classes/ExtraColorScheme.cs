namespace DocumentModel.Drawings;

/// <summary>
/// Extra Color Scheme.
/// </summary>
public partial class ExtraColorScheme
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public DocumentModel.Drawings.ColorScheme? ColorScheme { get; set; }
  
  /// <summary>
  /// ColorMap.
  /// </summary>
  public DocumentModel.Drawings.ColorMap? ColorMap { get; set; }
  
}
