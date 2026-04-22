namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class StrokeChildType
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeWeight() => !String.IsNullOrEmpty(Weight);
  public bool ShouldSerializeColor() => !String.IsNullOrEmpty(Color);
  public bool ShouldSerializeColor2() => !String.IsNullOrEmpty(Color2);
  public bool ShouldSerializeOpacity() => !String.IsNullOrEmpty(Opacity);
  public bool ShouldSerializeLineStyle() => LineStyle is not null;
  public bool ShouldSerializeMiterLimit() => MiterLimit is not null;
  public bool ShouldSerializeJoinStyle() => JoinStyle is not null;
  public bool ShouldSerializeEndCap() => EndCap is not null;
  public bool ShouldSerializeDashStyle() => !String.IsNullOrEmpty(DashStyle);
  public bool ShouldSerializeInsetPen() => InsetPen is not null;
  public bool ShouldSerializeFillType() => FillType is not null;
  public bool ShouldSerializeSource() => !String.IsNullOrEmpty(Source);
  public bool ShouldSerializeImageAspect() => ImageAspect is not null;
  public bool ShouldSerializeImageSize() => !String.IsNullOrEmpty(ImageSize);
  public bool ShouldSerializeImageAlignShape() => ImageAlignShape is not null;
  public bool ShouldSerializeStartArrow() => StartArrow is not null;
  public bool ShouldSerializeStartArrowWidth() => StartArrowWidth is not null;
  public bool ShouldSerializeStartArrowLength() => StartArrowLength is not null;
  public bool ShouldSerializeEndArrow() => EndArrow is not null;
  public bool ShouldSerializeEndArrowWidth() => EndArrowWidth is not null;
  public bool ShouldSerializeEndArrowLength() => EndArrowLength is not null;
  public bool ShouldSerializeHref() => !String.IsNullOrEmpty(Href);
  public bool ShouldSerializeAlternateImageReference() => !String.IsNullOrEmpty(AlternateImageReference);
  public bool ShouldSerializeTitle() => !String.IsNullOrEmpty(Title);
  public bool ShouldSerializeForceDash() => ForceDash is not null;
}
