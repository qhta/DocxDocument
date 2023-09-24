namespace DocumentModel.Wordprocessing;


/// <summary>
///   Picture Numbering Symbol Definition.
/// </summary>
public partial class NumberingPictureBullet
{
  
  /// <summary>
  ///   numPicBulletId
  /// </summary>
  public Int32? NumberingPictureBulletId { get; set; }
  
  
  /// <summary>
  ///   PictureBulletBase.
  /// </summary>
  public PictureBulletBase? PictureBulletBase { get; set; }
  
  
  /// <summary>
  ///   Drawing.
  /// </summary>
  public Drawing? Drawing { get; set; }
  
}
