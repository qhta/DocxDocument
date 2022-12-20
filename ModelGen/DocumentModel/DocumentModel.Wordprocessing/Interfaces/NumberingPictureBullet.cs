namespace DocumentModel.Wordprocessing;

/// <summary>
/// Picture Numbering Symbol Definition.
/// </summary>
public partial interface NumberingPictureBullet
{
  /// <summary>
  /// numPicBulletId
  /// </summary>
  public Int32? NumberingPictureBulletId { get; set; }
  
  /// <summary>
  /// PictureBulletBase.
  /// </summary>
  public DocumentModel.Wordprocessing.PictureBulletBase? PictureBulletBase { get; set; }
  
  /// <summary>
  /// Drawing.
  /// </summary>
  public DocumentModel.Wordprocessing.Drawing? Drawing { get; set; }
  
}
