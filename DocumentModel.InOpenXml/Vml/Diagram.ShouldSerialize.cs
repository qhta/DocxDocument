namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Diagram
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeStyle() => Style is not null;
  public bool ShouldSerializeAutoFormat() => AutoFormat is not null;
  public bool ShouldSerializeReverse() => Reverse is not null;
  public bool ShouldSerializeAutoLayout() => AutoLayout is not null;
  public bool ShouldSerializeScaleX() => ScaleX is not null;
  public bool ShouldSerializeScaleY() => ScaleY is not null;
  public bool ShouldSerializeFontSize() => FontSize is not null;
  public bool ShouldSerializeConstrainBounds() => ConstrainBounds is not null;
  public bool ShouldSerializeBaseTextScale() => BaseTextScale is not null;
  public bool ShouldSerializeRelationTable() => RelationTable is not null;
}
