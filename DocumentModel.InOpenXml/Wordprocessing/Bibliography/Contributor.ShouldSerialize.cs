namespace DocumentModel.Wordprocessing;

public partial class Contributor
{
  public bool ShouldSerializeFirst() => First is not null;
  public bool ShouldSerializeMiddle() => Middle is not null;
  public bool ShouldSerializeLast() => Last is not null;
  public bool ShouldSerializeSuffix() => Suffix is not null;
  public bool ShouldSerializeCorporate() => Corporate is not null;
}
