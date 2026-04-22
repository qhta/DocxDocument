namespace DocumentModel;

#pragma warning disable CS1591

public partial class HeadingPair
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeNumber() => Number is not null;
}
