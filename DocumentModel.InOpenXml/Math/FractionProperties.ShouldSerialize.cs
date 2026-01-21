namespace DocumentModel.Math;

public partial class FractionProperties
{
  public bool ShouldSerializeFractionType() => FractionType is not null;
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
