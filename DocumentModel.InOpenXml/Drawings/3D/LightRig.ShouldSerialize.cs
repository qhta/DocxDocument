namespace DocumentModel.Drawings;
#pragma warning disable CS1591
public partial class LightRig
{
  public bool ShouldSerializeRig() => Rig is not null;
  public bool ShouldSerializeDirection() => Direction is not null;
  public bool ShouldSerializeRotation() => Rotation is not null;
}
