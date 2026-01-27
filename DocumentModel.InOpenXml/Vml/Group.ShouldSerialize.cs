namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Group
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeStyle() => Style is not null;
  public bool ShouldSerializeHref() => Href is not null;
  public bool ShouldSerializeTarget() => Target is not null;
  public bool ShouldSerializeClass() => Class is not null;
  public bool ShouldSerializeTitle() => Title is not null;
  public bool ShouldSerializeAlternate() => Alternate is not null;
  public bool ShouldSerializeCoordinateSize() => CoordinateSize is not null;
  public bool ShouldSerializeCoordinateOrigin() => CoordinateOrigin is not null;
  public bool ShouldSerializeWrapCoordinates() => WrapCoordinates is not null;
  public bool ShouldSerializePrint() => Print is not null;
  public bool ShouldSerializeOptionalString() => OptionalString is not null;
  public bool ShouldSerializeOned() => Oned is not null;
  public bool ShouldSerializeRegroupId() => RegroupId is not null;
  public bool ShouldSerializeDoubleClickNotify() => DoubleClickNotify is not null;
  public bool ShouldSerializeButton() => Button is not null;
  public bool ShouldSerializeUserHidden() => UserHidden is not null;
  public bool ShouldSerializeBullet() => Bullet is not null;
  public bool ShouldSerializeHorizontal() => Horizontal is not null;
  public bool ShouldSerializeHorizontalStandard() => HorizontalStandard is not null;
  public bool ShouldSerializeHorizontalNoShade() => HorizontalNoShade is not null;
  public bool ShouldSerializeHorizontalPercentage() => HorizontalPercentage is not null;
  public bool ShouldSerializeHorizontalAlignment() => HorizontalAlignment is not null;
  public bool ShouldSerializeAllowInCell() => AllowInCell is not null;
  public bool ShouldSerializeAllowOverlap() => AllowOverlap is not null;
  public bool ShouldSerializeUserDrawn() => UserDrawn is not null;
  public bool ShouldSerializeDiagramLayout() => DiagramLayout is not null;
  public bool ShouldSerializeDiagramNodeKind() => DiagramNodeKind is not null;
  public bool ShouldSerializeDiagramLayoutMostRecentUsed() => DiagramLayoutMostRecentUsed is not null;
  public bool ShouldSerializeInsetMode() => InsetMode is not null;
  public bool ShouldSerializeGfxdata() => Gfxdata is not null;
  public bool ShouldSerializeEditAs() => EditAs is not null;
  public bool ShouldSerializeTableProperties() => TableProperties is not null;
  public bool ShouldSerializeTableLimits() => TableLimits is not null;
  public bool ShouldSerializeChildGroup() => ChildGroup is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializeShapetype() => Shapetype is not null;
  public bool ShouldSerializeArc() => Arc is not null;
  public bool ShouldSerializeCurve() => Curve is not null;
  public bool ShouldSerializeImageFile() => ImageFile is not null;
  public bool ShouldSerializeLine() => Line is not null;
  public bool ShouldSerializeOval() => Oval is not null;
  public bool ShouldSerializePolyLine() => PolyLine is not null;
  public bool ShouldSerializeRectangle() => Rectangle is not null;
  public bool ShouldSerializeRoundRectangle() => RoundRectangle is not null;
  public bool ShouldSerializeDiagram() => Diagram is not null;
  public bool ShouldSerializeLock() => Lock is not null;
  public bool ShouldSerializeClipPath() => ClipPath is not null;
  public bool ShouldSerializeTextWrap() => TextWrap is not null;
  public bool ShouldSerializeAnchorLock() => AnchorLock is not null;
}
