namespace DocumentModel.Wordprocessing;

/// <summary>
///   Numbering Definitions.
/// </summary>
public class Numbering: ModelElement
{
  public Collection<NumberingPictureBullet>? NumberingPictureBullets { get; set; }

  public Collection<AbstractNum>? AbstractNums { get; set; }

  public Collection<NumberingInstance>? NumberingInstances { get; set; }

  public Int32? NumberingIdMacAtCleanup { get; set; }
}