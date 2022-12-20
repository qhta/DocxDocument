namespace DocumentModel.Drawings;

/// <summary>
/// Format Scheme.
/// </summary>
public partial interface FormatScheme
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get; set; }
  
  /// <summary>
  /// Fill Style List.
  /// </summary>
  public DocumentModel.Drawings.FillStyleList? FillStyleList { get; set; }
  
  /// <summary>
  /// Line Style List.
  /// </summary>
  public DocumentModel.Drawings.LineStyleList? LineStyleList { get; set; }
  
  /// <summary>
  /// Effect Style List.
  /// </summary>
  public DocumentModel.Drawings.EffectStyleList? EffectStyleList { get; set; }
  
  /// <summary>
  /// Background Fill Style List.
  /// </summary>
  public DocumentModel.Drawings.BackgroundFillStyleList? BackgroundFillStyleList { get; set; }
  
}
