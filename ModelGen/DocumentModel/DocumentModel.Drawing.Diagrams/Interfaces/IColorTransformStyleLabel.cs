namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Style Label.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IFillColorList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ILineColorList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IEffectColorList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ITextLineColorList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ITextFillColorList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.ITextEffectColorList))]
public interface IColorTransformStyleLabel // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Fill Color List.
  /// </summary>
  public IFillColorList? FillColorList { get ; set; }
  
  /// <summary>
  /// Line Color List.
  /// </summary>
  public ILineColorList? LineColorList { get ; set; }
  
  /// <summary>
  /// Effect Color List.
  /// </summary>
  public IEffectColorList? EffectColorList { get ; set; }
  
  /// <summary>
  /// Text Line Color List.
  /// </summary>
  public ITextLineColorList? TextLineColorList { get ; set; }
  
  /// <summary>
  /// Text Fill Color List.
  /// </summary>
  public ITextFillColorList? TextFillColorList { get ; set; }
  
  /// <summary>
  /// Text Effect Color List.
  /// </summary>
  public ITextEffectColorList? TextEffectColorList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList { get ; set; }
  
}
