namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PageSize
{
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeHeight() => Height is not null;
  public bool ShouldSerializeOrient() => Orient is not null;
  public bool ShouldSerializePaperSize() => PaperSize is not null;
}
