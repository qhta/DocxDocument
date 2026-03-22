namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class ShapeGuide
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeFormula() => Formula is not null;
}
