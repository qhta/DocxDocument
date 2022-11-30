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
  public DocumentModel.Drawing.IFillStyleList? FillStyleList { get ; set; }
  
  /// <summary>
  /// Line Style List.
  /// </summary>
  public DocumentModel.Drawing.ILineStyleList? LineStyleList { get ; set; }
  
  /// <summary>
  /// Effect Style List.
  /// </summary>
  public DocumentModel.Drawing.IEffectStyleList? EffectStyleList { get ; set; }
  
  /// <summary>
  /// Background Fill Style List.
  /// </summary>
  public DocumentModel.Drawing.IBackgroundFillStyleList? BackgroundFillStyleList { get ; set; }
  
}
