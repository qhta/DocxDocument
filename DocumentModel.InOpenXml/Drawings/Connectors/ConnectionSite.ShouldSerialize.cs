namespace DocumentModel.Drawings;

public partial class ConnectionSite
{
  public bool ShouldSerializeAngle() => Angle is not null;
  public bool ShouldSerializePosition() => Position is not null;
}
