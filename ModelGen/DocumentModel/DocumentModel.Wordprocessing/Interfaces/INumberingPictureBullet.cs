namespace DocumentModel.Wordprocessing;

/// <summary>
/// Picture Numbering Symbol Definition.
/// </summary>
public interface INumberingPictureBullet // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// numPicBulletId
  /// </summary>
  public Int32? NumberingPictureBulletId { get ; set; }
  
  /// <summary>
  /// PictureBulletBase.
  /// </summary>
  public IPictureBulletBase? PictureBulletBase { get ; set; }
  
  /// <summary>
  /// Drawing.
  /// </summary>
  public IDrawing? Drawing { get ; set; }
  
}
