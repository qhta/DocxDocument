namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class Bar
{
  public bool ShouldSerializeBarProperties() => BarProperties is not null;
  public bool ShouldSerializeArgument() => Base is not null;
}
