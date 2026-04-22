namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Background
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeFilled() => Filled is not null;
  public bool ShouldSerializeFillcolor() => !String.IsNullOrEmpty(Fillcolor);
  public bool ShouldSerializeBlackWhiteMode() => BlackWhiteMode is not null;
  public bool ShouldSerializePureBlackWhiteMode() => PureBlackWhiteMode is not null;
  public bool ShouldSerializeNormalBlackWhiteMode() => NormalBlackWhiteMode is not null;
  public bool ShouldSerializeTargetScreenSize() => TargetScreenSize is not null;
  public bool ShouldSerializeFill() => Fill is not null;
}
