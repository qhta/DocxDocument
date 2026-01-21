namespace DocumentModel.Math;

public partial class BorderBox
{
  public bool ShouldSerializeBorderBoxProperties() => BorderBoxProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
}
