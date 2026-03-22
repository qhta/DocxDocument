namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class Extrusion
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeRender() => Render is not null;
  public bool ShouldSerializeViewpointOrigin() => ViewpointOrigin is not null;
  public bool ShouldSerializeViewpoint() => Viewpoint is not null;
  public bool ShouldSerializeSkewAngle() => SkewAngle is not null;
  public bool ShouldSerializeSkewAmount() => SkewAmount is not null;
  public bool ShouldSerializeForceDepth() => ForceDepth is not null;
  public bool ShouldSerializeBackDepth() => BackDepth is not null;
  public bool ShouldSerializeOrientation() => Orientation is not null;
  public bool ShouldSerializeOrientationAngle() => OrientationAngle is not null;
  public bool ShouldSerializeLockRotationCenter() => LockRotationCenter is not null;
  public bool ShouldSerializeAutoRotationCenter() => AutoRotationCenter is not null;
  public bool ShouldSerializeRotationCenter() => RotationCenter is not null;
  public bool ShouldSerializeRotationAngle() => RotationAngle is not null;
  public bool ShouldSerializeColor() => Color is not null;
  public bool ShouldSerializeShininess() => Shininess is not null;
  public bool ShouldSerializeSpecularity() => Specularity is not null;
  public bool ShouldSerializeDiffusity() => Diffusity is not null;
  public bool ShouldSerializeMetal() => Metal is not null;
  public bool ShouldSerializeEdge() => Edge is not null;
  public bool ShouldSerializeFacet() => Facet is not null;
  public bool ShouldSerializeLightFace() => LightFace is not null;
  public bool ShouldSerializeBrightness() => Brightness is not null;
  public bool ShouldSerializeLightPosition() => LightPosition is not null;
  public bool ShouldSerializeLightLevel() => LightLevel is not null;
  public bool ShouldSerializeLightHarsh() => LightHarsh is not null;
  public bool ShouldSerializeLightPosition2() => LightPosition2 is not null;
  public bool ShouldSerializeLightLevel2() => LightLevel2 is not null;
  public bool ShouldSerializeLightHarsh2() => LightHarsh2 is not null;
}
