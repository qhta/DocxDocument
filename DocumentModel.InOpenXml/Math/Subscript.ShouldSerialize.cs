namespace DocumentModel.Math;

public partial class Subscript
{
  public bool ShouldSerializeSubscriptProperties() => SubscriptProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
  public bool ShouldSerializeSubArgument() => SubArgument is not null;
}
