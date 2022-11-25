namespace DocumentModel.Drawing;

/// <summary>
/// Picture Bullet.
/// </summary>
public interface IPictureBullet // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Blip.
  /// </summary>
  public DocumentModel.Drawing.IBlip? Blip { get ; set; }
  
}
