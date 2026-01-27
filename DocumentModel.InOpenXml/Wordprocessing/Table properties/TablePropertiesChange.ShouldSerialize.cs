namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TablePropertiesChange
{
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTableProperties() => PreviousTableProperties is not null;
}
