namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class NonVisualConnectorProperties
{
  public bool ShouldSerializeConnectionShapeLocks() => ConnectionShapeLocks is not null;
  public bool ShouldSerializeStartConnection() => StartConnection is not null;
  public bool ShouldSerializeEndConnection() => EndConnection is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
