namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class DashStop
{
  public bool ShouldSerializeDashLength() => DashLength is not null;
  public bool ShouldSerializeSpaceLength() => SpaceLength is not null;
}
