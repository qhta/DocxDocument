namespace DocumentModel.Wordprocessing.Drawings;

public partial class GradientFillProperties
{
  public bool ShouldSerializeGradientStopList() => GradientStopList is not null;
  public bool ShouldSerializeLinearShadeProperties() => LinearShadeProperties is not null;
  public bool ShouldSerializePathShadeProperties() => PathShadeProperties is not null;
}
