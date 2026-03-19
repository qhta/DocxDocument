namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class DataModelRoot
{
  public bool ShouldSerializePointList() => PointList is not null && PointList.Count > 0;
  public bool ShouldSerializeConnectionList() => ConnectionList is not null && ConnectionList.Count > 0;
  public bool ShouldSerializeBackground() => Background is not null;
  public bool ShouldSerializeWhole() => Whole is not null;
  public bool ShouldSerializeDataModelExtensionList() => DataModelExtensionList is not null && DataModelExtensionList.Count > 0;
}
