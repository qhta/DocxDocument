namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class ArgumentProperties
{
  public bool ShouldSerializeArgumentSize() => ArgumentSize is not null;
}
