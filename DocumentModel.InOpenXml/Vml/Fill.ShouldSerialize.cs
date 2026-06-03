namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Fill
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeColor() => !String.IsNullOrEmpty(Color!);
  public bool ShouldSerializeOpacity() => !String.IsNullOrEmpty(Opacity!);
  public bool ShouldSerializeColor2() => !String.IsNullOrEmpty(Color2!);
  public bool ShouldSerializeSource() => !String.IsNullOrEmpty(Source!);
  public bool ShouldSerializeHref() => !String.IsNullOrEmpty(Href!);
  public bool ShouldSerializeAlternateImageReference() => !String.IsNullOrEmpty(AlternateImageReference!);
  public bool ShouldSerializeSize() => !String.IsNullOrEmpty(Size!);
  public bool ShouldSerializeOrigin() => !String.IsNullOrEmpty(Origin!);
  public bool ShouldSerializePosition() => !String.IsNullOrEmpty(Position!);
  public bool ShouldSerializeAspect() => Aspect is not null;
  public bool ShouldSerializeColors() => !String.IsNullOrEmpty(Colors!);
  public bool ShouldSerializeAngle() => Angle is not null;
  public bool ShouldSerializeAlignShape() => AlignShape is not null;
  public bool ShouldSerializeFocus() => !String.IsNullOrEmpty(Focus!);
  public bool ShouldSerializeFocusSize() => !String.IsNullOrEmpty(FocusSize!);
  public bool ShouldSerializeFocusPosition() => !String.IsNullOrEmpty(FocusPosition!);
  public bool ShouldSerializeMethod() => Method is not null;
  public bool ShouldSerializeDetectMouseClick() => DetectMouseClick is not null;
  public bool ShouldSerializeTitle() => !String.IsNullOrEmpty(Title!);
  public bool ShouldSerializeOpacity2() => !String.IsNullOrEmpty(Opacity2!);
  public bool ShouldSerializeRecolor() => Recolor is not null;
  public bool ShouldSerializeRotate() => Rotate is not null;
  public bool ShouldSerializeRelationshipId() => !String.IsNullOrEmpty(RelationshipId!);
  public bool ShouldSerializeFillExtendedProperties() => FillExtendedProperties is not null;
}
