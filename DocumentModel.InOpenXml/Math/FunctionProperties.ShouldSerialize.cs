namespace DocumentModel.Math;

public partial class FunctionProperties
{
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
