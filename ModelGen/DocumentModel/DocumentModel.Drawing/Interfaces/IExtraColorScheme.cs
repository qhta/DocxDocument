namespace DocumentModel.Drawing;

/// <summary>
/// Extra Color Scheme.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IColorMap))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IColorScheme))]
public interface IExtraColorScheme // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// ColorScheme.
  /// </summary>
  public IColorScheme? ColorScheme { get ; set; }
  
  /// <summary>
  /// ColorMap.
  /// </summary>
  public DocumentModel.Drawing.IColorMap? ColorMap { get ; set; }
  
}
