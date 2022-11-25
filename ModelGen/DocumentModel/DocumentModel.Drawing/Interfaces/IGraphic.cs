namespace DocumentModel.Drawing;

/// <summary>
/// Graphic Object.
/// </summary>
public interface IGraphic // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Graphic Object Data.
  /// </summary>
  public DocumentModel.Drawing.IGraphicData? GraphicData { get ; set; }
  
}
