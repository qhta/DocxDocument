namespace DocumentModel.Drawing;

/// <summary>
/// Format Scheme.
/// </summary>
public interface IFormatScheme // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Fill Style List.
  /// </summary>
  public IFillStyleList? FillStyleList { get ; set; }
  
  /// <summary>
  /// Line Style List.
  /// </summary>
  public ILineStyleList? LineStyleList { get ; set; }
  
  /// <summary>
  /// Effect Style List.
  /// </summary>
  public IEffectStyleList? EffectStyleList { get ; set; }
  
  /// <summary>
  /// Background Fill Style List.
  /// </summary>
  public IBackgroundFillStyleList? BackgroundFillStyleList { get ; set; }
  
}
