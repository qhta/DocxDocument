namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FitText
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeValue() => Value is not null;
}
