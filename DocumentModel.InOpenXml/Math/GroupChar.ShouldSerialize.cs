namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class GroupChar
{
  public bool ShouldSerializeGroupCharProperties() => GroupCharProperties is not null;
  public bool ShouldSerializeArgument() => Base is not null;
}
