namespace DocumentModel.Presentation;

/// <summary>
/// By.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IHslColor))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IRgbColor))]
public interface IByColor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// RGB.
  /// </summary>
  public DocumentModel.Presentation.IRgbColor? RgbColor { get ; set; }
  
  /// <summary>
  /// HSL.
  /// </summary>
  public DocumentModel.Presentation.IHslColor? HslColor { get ; set; }
  
}
