namespace DocumentModel.Drawing;

/// <summary>
/// Extra Color Scheme.
/// </summary>
public interface IExtraColorScheme // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public DocumentModel.Drawing.IColorScheme? ColorScheme { get ; set; }
  
  /// <summary>
  /// ColorMap.
  /// </summary>
  public DocumentModel.Drawing.IColorMappingType? ColorMap { get ; set; }
  
}
