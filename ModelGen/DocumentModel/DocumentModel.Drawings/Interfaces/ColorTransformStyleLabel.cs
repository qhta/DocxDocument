namespace DocumentModel.Drawings;

/// <summary>
/// Style Label.
/// </summary>
public interface ColorTransformStyleLabel
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Fill Color List.
  /// </summary>
  public DocumentModel.Drawings.FillColorList? FillColorList { get ; set; }
  
  /// <summary>
  /// Line Color List.
  /// </summary>
  public DocumentModel.Drawings.LineColorList? LineColorList { get ; set; }
  
  /// <summary>
  /// Effect Color List.
  /// </summary>
  public DocumentModel.Drawings.EffectColorList? EffectColorList { get ; set; }
  
  /// <summary>
  /// Text Line Color List.
  /// </summary>
  public DocumentModel.Drawings.TextLineColorList? TextLineColorList { get ; set; }
  
  /// <summary>
  /// Text Fill Color List.
  /// </summary>
  public DocumentModel.Drawings.TextFillColorList? TextFillColorList { get ; set; }
  
  /// <summary>
  /// Text Effect Color List.
  /// </summary>
  public DocumentModel.Drawings.TextEffectColorList? TextEffectColorList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get ; set; }
  
}
