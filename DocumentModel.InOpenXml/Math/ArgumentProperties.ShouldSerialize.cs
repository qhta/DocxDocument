namespace DocumentModel.Math;

public partial class ArgumentProperties
{
  public bool ShouldSerializeArgumentSize() => ArgumentSize is not null;
}
