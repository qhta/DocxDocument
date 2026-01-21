namespace DocumentModel.Math;

public partial class Box
{
  public bool ShouldSerializeBoxProperties() => BoxProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
}
