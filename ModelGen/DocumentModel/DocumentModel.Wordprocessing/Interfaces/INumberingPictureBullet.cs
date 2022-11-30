namespace DocumentModel.Wordprocessing;

/// <summary>
/// Picture Numbering Symbol Definition.
/// </summary>
public interface INumberingPictureBullet // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// numPicBulletId
  /// </summary>
  public System.Int32? NumberingPictureBulletId { get ; set; }
  
  /// <summary>
  /// PictureBulletBase.
  /// </summary>
  public DocumentModel.Wordprocessing.IPictureBulletBase? PictureBulletBase { get ; set; }
  
  /// <summary>
  /// Drawing.
  /// </summary>
  public DocumentModel.Wordprocessing.IDrawing? Drawing { get ; set; }
  
}
