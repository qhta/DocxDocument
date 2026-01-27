namespace DocumentModel;

#pragma warning disable CS1591

public partial class DualBool
{
  public bool ShouldSerializeVal() => Val is not null;
  public bool ShouldSerializeCS() => CS is not null;
}
