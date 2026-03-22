namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ArcTo
{
  public bool ShouldSerializeWidthRadius() => WidthRadius is not null;
  public bool ShouldSerializeHeightRadius() => HeightRadius is not null;
  public bool ShouldSerializeStartAngle() => StartAngle is not null;
  public bool ShouldSerializeSwingAngle() => SwingAngle is not null;
}
