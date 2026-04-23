namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class DocumentBackground
{
  public bool ShouldSerializeColor() => Color is not null && ShouldSerialize(Color);
  public bool ShouldSerializeBackground() => Background is not null && ShouldSerialize(Background);
}
