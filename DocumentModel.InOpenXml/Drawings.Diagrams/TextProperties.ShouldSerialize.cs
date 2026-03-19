namespace DocumentModel.Drawings.Diagrams;

#pragma warning disable CS1591

public partial class TextProperties
{
  public bool ShouldSerializeShape3DType() => Shape3DType is not null;
  public bool ShouldSerializeFlatText() => FlatText is not null;
}
