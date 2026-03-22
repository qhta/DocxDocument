namespace DocumentModel.Math;
#pragma warning disable CS1591
public partial class BorderBox
{
  public bool ShouldSerializeBorderBoxProperties() => BorderBoxProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
}
