namespace DocumentModel.Drawing;

/// <summary>
/// Picture Bullet.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBlip))]
public interface IPictureBullet // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blip.
  /// </summary>
  public DocumentModel.Drawing.IBlip? Blip { get ; set; }
  
}
