namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Group
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeStyle() => !String.IsNullOrEmpty(Style);
  public bool ShouldSerializeHref() => !String.IsNullOrEmpty(Href);
  public bool ShouldSerializeTarget() => !String.IsNullOrEmpty(Target);
  public bool ShouldSerializeClass() => !String.IsNullOrEmpty(Class);
  public bool ShouldSerializeTitle() => !String.IsNullOrEmpty(Title);
  public bool ShouldSerializeAlternate() => !String.IsNullOrEmpty(Alternate);
  public bool ShouldSerializeCoordinateSize() => !String.IsNullOrEmpty(CoordinateSize);
  public bool ShouldSerializeCoordinateOrigin() => !String.IsNullOrEmpty(CoordinateOrigin);
  public bool ShouldSerializeWrapCoordinates() => !String.IsNullOrEmpty(WrapCoordinates);
  public bool ShouldSerializePrint() => Print is not null;
  public bool ShouldSerializeOptionalString() => !String.IsNullOrEmpty(OptionalString);
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
  public bool ShouldSerializeGfxData() => GfxData is not null;
  public bool ShouldSerializeEditAs() => EditAs is not null;
  public bool ShouldSerializeTableProperties() => !String.IsNullOrEmpty(TableProperties);
  public bool ShouldSerializeTableLimits() => !String.IsNullOrEmpty(TableLimits);
  public bool ShouldSerializeChildGroup() => ChildGroup is not null;
  public bool ShouldSerializeShape() => Shape is not null;
  public bool ShouldSerializeShapeType() => ShapeType is not null;
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
