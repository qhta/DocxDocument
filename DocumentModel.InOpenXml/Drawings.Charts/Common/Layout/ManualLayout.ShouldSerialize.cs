namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class ManualLayout
{
  public bool ShouldSerializeLayoutTarget() => LayoutTarget is not null;
  public bool ShouldSerializeLeftMode() => LeftMode is not null;
  public bool ShouldSerializeTopMode() => TopMode is not null;
  public bool ShouldSerializeWidthMode() => WidthMode is not null;
  public bool ShouldSerializeHeightMode() => HeightMode is not null;
  public bool ShouldSerializeLeft() => Left is not null;
  public bool ShouldSerializeTop() => Top is not null;
  public bool ShouldSerializeWidth() => Width is not null;
  public bool ShouldSerializeHeight() => Height is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
