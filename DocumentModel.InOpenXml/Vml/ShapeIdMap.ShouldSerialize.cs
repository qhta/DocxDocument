namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class ShapeIdMap
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeData() => !String.IsNullOrEmpty(Data);
}
