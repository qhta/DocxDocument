namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Contributor
{
  public bool ShouldSerializeFirst() => !String.IsNullOrEmpty(First);
  public bool ShouldSerializeMiddle() => !String.IsNullOrEmpty(Middle);
  public bool ShouldSerializeLast() => !String.IsNullOrEmpty(Last);
  public bool ShouldSerializeSuffix() => !String.IsNullOrEmpty(Suffix);
  public bool ShouldSerializeCorporate() => !String.IsNullOrEmpty(Corporate);
}
