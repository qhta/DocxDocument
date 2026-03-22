namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class Fill
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeColor() => Color is not null;
  public bool ShouldSerializeOpacity() => Opacity is not null;
  public bool ShouldSerializeColor2() => Color2 is not null;
  public bool ShouldSerializeSource() => Source is not null;
  public bool ShouldSerializeHref() => Href is not null;
  public bool ShouldSerializeAlternateImageReference() => AlternateImageReference is not null;
  public bool ShouldSerializeSize() => Size is not null;
  public bool ShouldSerializeOrigin() => Origin is not null;
  public bool ShouldSerializePosition() => Position is not null;
  public bool ShouldSerializeAspect() => Aspect is not null;
  public bool ShouldSerializeColors() => Colors is not null;
  public bool ShouldSerializeAngle() => Angle is not null;
  public bool ShouldSerializeAlignShape() => AlignShape is not null;
  public bool ShouldSerializeFocus() => Focus is not null;
  public bool ShouldSerializeFocusSize() => FocusSize is not null;
  public bool ShouldSerializeFocusPosition() => FocusPosition is not null;
  public bool ShouldSerializeMethod() => Method is not null;
  public bool ShouldSerializeDetectMouseClick() => DetectMouseClick is not null;
  public bool ShouldSerializeTitle() => Title is not null;
  public bool ShouldSerializeOpacity2() => Opacity2 is not null;
  public bool ShouldSerializeRecolor() => Recolor is not null;
  public bool ShouldSerializeRotate() => Rotate is not null;
  public bool ShouldSerializeRelationshipId() => RelationshipId is not null;
  public bool ShouldSerializeFillExtendedProperties() => FillExtendedProperties is not null;
}
