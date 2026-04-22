namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Relation
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeSourceId() => !String.IsNullOrEmpty(SourceId);
  public bool ShouldSerializeDestinationId() => !String.IsNullOrEmpty(DestinationId);
  public bool ShouldSerializeCenterShapeId() => !String.IsNullOrEmpty(CenterShapeId);
}
