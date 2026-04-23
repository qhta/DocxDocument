namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class FitText
{
  public bool ShouldSerializeId() => Id is not null && ShouldSerialize(Id);
  public bool ShouldSerializeWidth() => Width is not null && ShouldSerialize(Width);
}
