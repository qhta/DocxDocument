namespace DocumentModel.Math;

public partial class GroupChar
{
  public bool ShouldSerializeGroupCharProperties() => GroupCharProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
}
