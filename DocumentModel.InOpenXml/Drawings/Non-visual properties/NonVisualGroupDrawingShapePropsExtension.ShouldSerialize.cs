namespace DocumentModel.Drawings;

public partial class NonVisualGroupDrawingShapePropsExtension
{
  public bool ShouldSerializeNonVisualGroupProperties() => NonVisualGroupProperties is not null;
  public bool ShouldSerializeUri() => Uri is not null;
}
