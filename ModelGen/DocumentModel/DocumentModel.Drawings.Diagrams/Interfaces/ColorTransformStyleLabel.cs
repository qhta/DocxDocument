namespace DocumentModel.Drawings.Diagrams;

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
  public DocumentModel.Drawings.Diagrams.FillColorList? FillColorList { get ; set; }
  
  /// <summary>
  /// Line Color List.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.LineColorList? LineColorList { get ; set; }
  
  /// <summary>
  /// Effect Color List.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.EffectColorList? EffectColorList { get ; set; }
  
  /// <summary>
  /// Text Line Color List.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.TextLineColorList? TextLineColorList { get ; set; }
  
  /// <summary>
  /// Text Fill Color List.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.TextFillColorList? TextFillColorList { get ; set; }
  
  /// <summary>
  /// Text Effect Color List.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.TextEffectColorList? TextEffectColorList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList { get ; set; }
  
}
