namespace DocumentModel.Drawings.Charts;

#pragma warning disable CS1591

public partial class CategoryFilterException
{
  public bool ShouldSerializeSequenceOfReferences() => !String.IsNullOrEmpty(SequenceOfReferences);
  public bool ShouldSerializeShapeProperties() => ShapeProperties is not null;
  public bool ShouldSerializeExplosion() => Explosion is not null;
  public bool ShouldSerializeInvertIfNegativeBoolean() => InvertIfNegativeBoolean is not null;
  public bool ShouldSerializeBubble3D() => Bubble3D is not null;
  public bool ShouldSerializeMarker() => Marker is not null;
  public bool ShouldSerializeDataLabel() => DataLabel is not null;
}
