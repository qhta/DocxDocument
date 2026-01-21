namespace DocumentModel.Drawings;

public partial class ConnectionType
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeIndex() => Index is not null;
}
