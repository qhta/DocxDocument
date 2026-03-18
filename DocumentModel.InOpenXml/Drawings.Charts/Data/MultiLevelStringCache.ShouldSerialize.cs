namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class MultiLevelStringCache
{
  public bool ShouldSerializePointCount() => PointCount is not null;
  public bool ShouldSerializeLevels() => Levels is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
