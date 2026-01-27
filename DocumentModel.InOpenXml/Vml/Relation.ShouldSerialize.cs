namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Relation
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeSourceId() => SourceId is not null;
  public bool ShouldSerializeDestinationId() => DestinationId is not null;
  public bool ShouldSerializeCenterShapeId() => CenterShapeId is not null;
}
