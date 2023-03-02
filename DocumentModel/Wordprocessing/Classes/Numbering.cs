namespace DocumentModel.Wordprocessing;

/// <summary>
///   Numbering Definitions.
/// </summary>
public record Numbering
{
  public Collection<NumberingPictureBullet>? NumberingPictureBullets { get; set; }

  public Collection<AbstractNum>? AbstractNums { get; set; }

  public Collection<NumberingInstance>? NumberingInstances { get; set; }

  public Int32? NumberingIdMacAtCleanup { get; set; }
}