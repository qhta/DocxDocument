namespace DocumentModel.Vml;
#pragma warning disable CS1591
public partial class StrokeChildType
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeWeight() => Weight is not null;
  public bool ShouldSerializeColor() => Color is not null;
  public bool ShouldSerializeColor2() => Color2 is not null;
  public bool ShouldSerializeOpacity() => Opacity is not null;
  public bool ShouldSerializeLineStyle() => LineStyle is not null;
  public bool ShouldSerializeMiterLimit() => MiterLimit is not null;
  public bool ShouldSerializeJoinStyle() => JoinStyle is not null;
  public bool ShouldSerializeEndCap() => EndCap is not null;
  public bool ShouldSerializeDashStyle() => DashStyle is not null;
  public bool ShouldSerializeInsetPen() => InsetPen is not null;
  public bool ShouldSerializeFillType() => FillType is not null;
  public bool ShouldSerializeSource() => Source is not null;
  public bool ShouldSerializeImageAspect() => ImageAspect is not null;
  public bool ShouldSerializeImageSize() => ImageSize is not null;
  public bool ShouldSerializeImageAlignShape() => ImageAlignShape is not null;
  public bool ShouldSerializeStartArrow() => StartArrow is not null;
  public bool ShouldSerializeStartArrowWidth() => StartArrowWidth is not null;
  public bool ShouldSerializeStartArrowLength() => StartArrowLength is not null;
  public bool ShouldSerializeEndArrow() => EndArrow is not null;
  public bool ShouldSerializeEndArrowWidth() => EndArrowWidth is not null;
  public bool ShouldSerializeEndArrowLength() => EndArrowLength is not null;
  public bool ShouldSerializeHref() => Href is not null;
  public bool ShouldSerializeAlternateImageReference() => AlternateImageReference is not null;
  public bool ShouldSerializeTitle() => Title is not null;
  public bool ShouldSerializeForceDash() => ForceDash is not null;
}
