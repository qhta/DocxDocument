namespace DocumentModel.Drawings;

public partial class LightRig
{
  public bool ShouldSerializeRig() => Rig is not null;
  public bool ShouldSerializeDirection() => Direction is not null;
  public bool ShouldSerializeRotation() => Rotation is not null;
}
