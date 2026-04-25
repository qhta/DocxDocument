namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PageSize
{
  public bool ShouldSerializeWidth() => Width is not null && ShouldSerialize(Width);
  public bool ShouldSerializeHeight() => Height is not null && ShouldSerialize(Height);
  public bool ShouldSerializeOrient() => Orient is not null && ShouldSerialize(Orient);
  public bool ShouldSerializePaperSize() => PaperSize is not null && ShouldSerialize(PaperSize);
}