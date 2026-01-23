namespace DocumentModel.Math;

public partial class Run
{
  public bool ShouldSerializeMathRunProperties() => MathRunProperties is not null;
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
}
