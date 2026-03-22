namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ConnectionSite
{
  public bool ShouldSerializeAngle() => Angle is not null;
  public bool ShouldSerializePosition() => Position is not null;
}
