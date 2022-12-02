namespace DocumentModel.Drawing;

/// <summary>
/// Extra Color Scheme.
/// </summary>
public interface IExtraColorScheme // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public IColorScheme? ColorScheme { get ; set; }
  
  /// <summary>
  /// ColorMap.
  /// </summary>
  public IColorMap? ColorMap { get ; set; }
  
}
