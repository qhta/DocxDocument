namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class Radical
{
  public bool ShouldSerializeRadicalProperties() => RadicalProperties is not null;
  public bool ShouldSerializeDegree() => Degree is not null;
  public bool ShouldSerializeBase() => Base is not null;
}
