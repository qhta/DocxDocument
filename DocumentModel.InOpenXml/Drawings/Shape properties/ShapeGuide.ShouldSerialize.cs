namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class ShapeGuide
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeFormula() => !String.IsNullOrEmpty(Formula);
}
