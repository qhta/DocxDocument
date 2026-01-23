namespace DocumentModel.Drawings;

public partial class DashStop
{
  public bool ShouldSerializeDashLength() => DashLength is not null;
  public bool ShouldSerializeSpaceLength() => SpaceLength is not null;
}
