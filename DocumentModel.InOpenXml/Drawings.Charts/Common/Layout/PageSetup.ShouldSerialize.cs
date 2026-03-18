namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class PageSetup
{
  public bool ShouldSerializePaperSize() => PaperSize is not null;
  public bool ShouldSerializeFirstPageNumber() => FirstPageNumber is not null;
  public bool ShouldSerializeOrientation() => Orientation is not null;
  public bool ShouldSerializeBlackAndWhite() => BlackAndWhite is not null;
  public bool ShouldSerializeDraft() => Draft is not null;
  public bool ShouldSerializeUseFirstPageNumber() => UseFirstPageNumber is not null;
  public bool ShouldSerializeHorizontalDpi() => HorizontalDpi is not null;
  public bool ShouldSerializeVerticalDpi() => VerticalDpi is not null;
  public bool ShouldSerializeCopies() => Copies is not null;
}
