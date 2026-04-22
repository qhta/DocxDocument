namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Stroke
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeWeight() => !String.IsNullOrEmpty(Weight);
  public bool ShouldSerializeColor() => !String.IsNullOrEmpty(Color);
  public bool ShouldSerializeOpacity() => !String.IsNullOrEmpty(Opacity);
  public bool ShouldSerializeLineStyle() => LineStyle is not null;
  public bool ShouldSerializeMiterLimit() => !String.IsNullOrEmpty(MiterLimit);
  public bool ShouldSerializeJoinStyle() => JoinStyle is not null;
  public bool ShouldSerializeEndCap() => EndCap is not null;
  public bool ShouldSerializeDashStyle() => !String.IsNullOrEmpty(DashStyle);
  public bool ShouldSerializeFillType() => FillType is not null;
  public bool ShouldSerializeSource() => !String.IsNullOrEmpty(Source);
  public bool ShouldSerializeImageAspect() => ImageAspect is not null;
  public bool ShouldSerializeImageSize() => !String.IsNullOrEmpty(ImageSize);
  public bool ShouldSerializeImageAlignShape() => ImageAlignShape is not null;
  public bool ShouldSerializeColor2() => !String.IsNullOrEmpty(Color2);
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
  public bool ShouldSerializeRelationshipId() => !String.IsNullOrEmpty(RelationshipId);
  public bool ShouldSerializeInsetpen() => Insetpen is not null;
  public bool ShouldSerializeLeftStroke() => LeftStroke is not null;
  public bool ShouldSerializeTopStroke() => TopStroke is not null;
  public bool ShouldSerializeRightStroke() => RightStroke is not null;
  public bool ShouldSerializeBottomStroke() => BottomStroke is not null;
  public bool ShouldSerializeColumnStroke() => ColumnStroke is not null;
}
