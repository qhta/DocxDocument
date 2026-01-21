namespace DocumentModel.Drawings;

public partial class ShapeGuide
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeFormula() => Formula is not null;
}
