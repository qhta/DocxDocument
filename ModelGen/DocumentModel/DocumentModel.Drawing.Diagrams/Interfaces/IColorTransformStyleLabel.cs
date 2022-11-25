namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Style Label.
/// </summary>
public interface IColorTransformStyleLabel // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Fill Color List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IColorsType? FillColorList { get ; set; }
  
  /// <summary>
  /// Line Color List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IColorsType? LineColorList { get ; set; }
  
  /// <summary>
  /// Effect Color List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IColorsType? EffectColorList { get ; set; }
  
  /// <summary>
  /// Text Line Color List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IColorsType? TextLineColorList { get ; set; }
  
  /// <summary>
  /// Text Fill Color List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IColorsType? TextFillColorList { get ; set; }
  
  /// <summary>
  /// Text Effect Color List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IColorsType? TextEffectColorList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
