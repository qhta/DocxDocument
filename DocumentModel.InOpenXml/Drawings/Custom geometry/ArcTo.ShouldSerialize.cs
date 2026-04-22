namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ArcTo
{
  public bool ShouldSerializeWidthRadius() => !String.IsNullOrEmpty(WidthRadius);
  public bool ShouldSerializeHeightRadius() => !String.IsNullOrEmpty(HeightRadius);
  public bool ShouldSerializeStartAngle() => !String.IsNullOrEmpty(StartAngle);
  public bool ShouldSerializeSwingAngle() => !String.IsNullOrEmpty(SwingAngle);
}
