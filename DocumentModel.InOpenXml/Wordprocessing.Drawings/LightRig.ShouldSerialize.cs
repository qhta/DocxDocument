namespace DocumentModel.Wordprocessing.Drawings;

public partial class LightRig
{
  public bool ShouldSerializeLightRigType() => LightRigType is not null;
  public bool ShouldSerializeLightDirectionType() => LightDirectionType is not null;
  public bool ShouldSerializeSphereCoordinates() => SphereCoordinates is not null;
}
