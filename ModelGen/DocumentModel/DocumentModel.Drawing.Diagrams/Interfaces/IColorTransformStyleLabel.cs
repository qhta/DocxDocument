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
  public DocumentModel.Drawing.Diagrams.IFillColorList? FillColorList { get ; set; }
  
  /// <summary>
  /// Line Color List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.ILineColorList? LineColorList { get ; set; }
  
  /// <summary>
  /// Effect Color List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IEffectColorList? EffectColorList { get ; set; }
  
  /// <summary>
  /// Text Line Color List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.ITextLineColorList? TextLineColorList { get ; set; }
  
  /// <summary>
  /// Text Fill Color List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.ITextFillColorList? TextFillColorList { get ; set; }
  
  /// <summary>
  /// Text Effect Color List.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.ITextEffectColorList? TextEffectColorList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList { get ; set; }
  
}
