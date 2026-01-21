namespace DocumentModel.Math;

public partial class SuperscriptProperties
{
  public bool ShouldSerializeControlProperties() => ControlProperties is not null;
}
