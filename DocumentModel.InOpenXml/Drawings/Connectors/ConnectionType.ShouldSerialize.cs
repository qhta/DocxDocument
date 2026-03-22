namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ConnectionType
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeIndex() => Index is not null;
}
