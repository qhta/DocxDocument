namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class StringDataType
{
  public bool ShouldSerializePointCount() => PointCount is not null;
}
