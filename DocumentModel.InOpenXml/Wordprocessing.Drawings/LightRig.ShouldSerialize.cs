namespace DocumentModel.Wordprocessing.Drawings;

#pragma warning disable CS1591

public partial class LightRig
{
  public bool ShouldSerializeLightRigType() => LightRigType is not null;
  public bool ShouldSerializeLightDirectionType() => LightDirectionType is not null;
  public bool ShouldSerializeSphereCoordinates() => SphereCoordinates is not null;
}
