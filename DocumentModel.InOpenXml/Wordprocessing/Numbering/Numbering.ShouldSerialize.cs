namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Numbering
{
  public bool ShouldSerializeNumberingIdMacAtCleanup() => NumberingIdMacAtCleanup is not null;
  public bool ShouldSerializeAbstractNums() => AbstractNums is not null;
  public bool ShouldSerializeNumberingInstances() => NumberingInstances is not null;
  public bool ShouldSerializeNumberingPictureBullets() => NumberingPictureBullets is not null;
}
