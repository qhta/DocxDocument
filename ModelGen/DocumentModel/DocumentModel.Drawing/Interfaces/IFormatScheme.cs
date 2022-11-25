namespace DocumentModel.Drawing;

/// <summary>
/// Format Scheme.
/// </summary>
public interface IFormatScheme // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Fill Style List.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? FillStyleList { get ; set; }
  
  /// <summary>
  /// Line Style List.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? LineStyleList { get ; set; }
  
  /// <summary>
  /// Effect Style List.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EffectStyleList { get ; set; }
  
  /// <summary>
  /// Background Fill Style List.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? BackgroundFillStyleList { get ; set; }
  
}
