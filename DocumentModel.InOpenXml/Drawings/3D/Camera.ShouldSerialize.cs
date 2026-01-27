namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Camera
{
  public bool ShouldSerializePreset() => Preset is not null;
  public bool ShouldSerializeFieldOfView() => FieldOfView is not null;
  public bool ShouldSerializeZoom() => Zoom is not null;
  public bool ShouldSerializeRotation() => Rotation is not null;
}
