namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Picture Numbering Symbol Definition.
/// </summary>
public class NumberingPictureBullet: ModelElement
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
  //public Drawing? Drawing { get; set; }
}