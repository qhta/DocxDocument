namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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