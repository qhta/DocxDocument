namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ConnectionSite
{
  public bool ShouldSerializeAngle() => !String.IsNullOrEmpty(Angle);
  public bool ShouldSerializePosition() => Position is not null;
}
