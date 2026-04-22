namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class DataModelRoot
{
  public bool ShouldSerializePointList() => PointList is not null;
  public bool ShouldSerializeConnectionList() => ConnectionList is not null;
  public bool ShouldSerializeBackground() => Background is not null;
  public bool ShouldSerializeWhole() => Whole is not null;
  public bool ShouldSerializeDataModelExtensionList() => DataModelExtensionList is not null;
}
