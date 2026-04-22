namespace DocumentModel.Drawings.ChartDrawings;

#pragma warning disable CS1591

public partial class ContentPart
{
  public bool ShouldSerializeRelationshipId() => !String.IsNullOrEmpty(RelationshipId);
  public bool ShouldSerializeBlackWhiteMode() => BlackWhiteMode is not null;
  public bool ShouldSerializeNonVisualContentPartProperties() => NonVisualContentPartProperties is not null;
  public bool ShouldSerializeApplicationNonVisualDrawingProperties() => ApplicationNonVisualDrawingProperties is not null;
  public bool ShouldSerializeTransform2D() => Transform2D is not null;
}
