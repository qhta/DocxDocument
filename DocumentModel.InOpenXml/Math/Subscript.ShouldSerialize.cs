namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class Subscript
{
  public bool ShouldSerializeSubscriptProperties() => SubscriptProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
  public bool ShouldSerializeSubArgument() => SubArgument is not null;
}
