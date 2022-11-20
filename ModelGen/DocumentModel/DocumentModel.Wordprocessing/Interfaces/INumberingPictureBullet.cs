namespace DocumentModel.Wordprocessing;

/// <summary>
/// Picture Numbering Symbol Definition.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDrawing))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPictureBulletBase))]
public interface INumberingPictureBullet // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// numPicBulletId
  /// </summary>
  public int? NumberingPictureBulletId { get ; set; }
  
  /// <summary>
  /// PictureBulletBase.
  /// </summary>
  public IPictureBulletBase? PictureBulletBase { get ; set; }
  
  /// <summary>
  /// Drawing.
  /// </summary>
  public DocumentModel.Wordprocessing.IDrawing? Drawing { get ; set; }
  
}
