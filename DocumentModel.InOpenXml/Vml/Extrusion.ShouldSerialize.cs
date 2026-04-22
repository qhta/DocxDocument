namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Extrusion
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeRender() => Render is not null;
  public bool ShouldSerializeViewpointOrigin() => !String.IsNullOrEmpty(ViewpointOrigin);
  public bool ShouldSerializeViewpoint() => !String.IsNullOrEmpty(Viewpoint);
  public bool ShouldSerializeSkewAngle() => SkewAngle is not null;
  public bool ShouldSerializeSkewAmount() => !String.IsNullOrEmpty(SkewAmount);
  public bool ShouldSerializeForceDepth() => !String.IsNullOrEmpty(ForceDepth);
  public bool ShouldSerializeBackDepth() => !String.IsNullOrEmpty(BackDepth);
  public bool ShouldSerializeOrientation() => !String.IsNullOrEmpty(Orientation);
  public bool ShouldSerializeOrientationAngle() => OrientationAngle is not null;
  public bool ShouldSerializeLockRotationCenter() => LockRotationCenter is not null;
  public bool ShouldSerializeAutoRotationCenter() => AutoRotationCenter is not null;
  public bool ShouldSerializeRotationCenter() => !String.IsNullOrEmpty(RotationCenter);
  public bool ShouldSerializeRotationAngle() => !String.IsNullOrEmpty(RotationAngle);
  public bool ShouldSerializeColor() => !String.IsNullOrEmpty(Color);
  public bool ShouldSerializeShininess() => Shininess is not null;
  public bool ShouldSerializeSpecularity() => !String.IsNullOrEmpty(Specularity);
  public bool ShouldSerializeDiffusity() => !String.IsNullOrEmpty(Diffusity);
  public bool ShouldSerializeMetal() => Metal is not null;
  public bool ShouldSerializeEdge() => !String.IsNullOrEmpty(Edge);
  public bool ShouldSerializeFacet() => !String.IsNullOrEmpty(Facet);
  public bool ShouldSerializeLightFace() => LightFace is not null;
  public bool ShouldSerializeBrightness() => !String.IsNullOrEmpty(Brightness);
  public bool ShouldSerializeLightPosition() => !String.IsNullOrEmpty(LightPosition);
  public bool ShouldSerializeLightLevel() => !String.IsNullOrEmpty(LightLevel);
  public bool ShouldSerializeLightHarsh() => LightHarsh is not null;
  public bool ShouldSerializeLightPosition2() => !String.IsNullOrEmpty(LightPosition2);
  public bool ShouldSerializeLightLevel2() => !String.IsNullOrEmpty(LightLevel2);
  public bool ShouldSerializeLightHarsh2() => LightHarsh2 is not null;
}
