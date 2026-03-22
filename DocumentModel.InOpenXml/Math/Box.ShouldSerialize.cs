namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class Box
{
  public bool ShouldSerializeBoxProperties() => BoxProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
}
