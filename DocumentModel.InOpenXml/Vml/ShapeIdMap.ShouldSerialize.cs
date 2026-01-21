namespace DocumentModel.Vml;

public partial class ShapeIdMap
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeData() => Data is not null;
}
