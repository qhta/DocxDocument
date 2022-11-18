namespace DocumentModel.Drawing;

/// <summary>
/// Graphic Object.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGraphicData))]
public interface IGraphic // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Graphic Object Data.
  /// </summary>
  public IGraphicData? GraphicData { get ; set; }
  
}
