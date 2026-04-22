namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class CategoryAxis
{
  public bool ShouldSerializeAutoLabeled() => AutoLabeled is not null;
  public bool ShouldSerializeLabelAlignment() => LabelAlignment is not null;
  public bool ShouldSerializeLabelOffset() => LabelOffset is not null;
  public bool ShouldSerializeTickLabelSkip() => TickLabelSkip is not null;
  public bool ShouldSerializeTickMarkSkip() => TickMarkSkip is not null;
  public bool ShouldSerializeNoMultiLevelLabels() => NoMultiLevelLabels is not null;
  public bool ShouldSerializeCatAxExtensionList() => CatAxExtensionList is not null;
}
