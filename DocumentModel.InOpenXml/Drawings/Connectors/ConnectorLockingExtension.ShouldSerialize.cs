namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ConnectorLockingExtension
{
  public bool ShouldSerializeGraphic() => Graphic is not null;
  public bool ShouldSerializeUri() => Uri is not null;
}
