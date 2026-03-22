namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class Function
{
  public bool ShouldSerializeFunctionProperties() => FunctionProperties is not null;
  public bool ShouldSerializeFunctionName() => FunctionName is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
}
