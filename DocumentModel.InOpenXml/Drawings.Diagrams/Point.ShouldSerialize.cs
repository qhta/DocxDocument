namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591
public partial class Point
{
  public bool ShouldSerializeModelId() => !String.IsNullOrEmpty(ModelId);
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeConnectionId() => !String.IsNullOrEmpty(ConnectionId);
  public bool ShouldSerializePropertySet() => PropertySet is not null;
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeTextBody() => TextBody is not null;
  public bool ShouldSerializePtExtensionList() => PtExtensionList is not null && PtExtensionList.Count > 0;
}
