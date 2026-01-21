namespace DocumentModel.Math;

public partial class SubscriptProperties
{
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
