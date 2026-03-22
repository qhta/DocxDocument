namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class Fraction
{
  public bool ShouldSerializeFractionProperties() => FractionProperties is not null;
  public bool ShouldSerializeNumerator() => Numerator is not null;
  public bool ShouldSerializeDenominator() => Denominator is not null;
}
