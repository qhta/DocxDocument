namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TablePropertiesChange
{
  public bool ShouldSerializeAnnotationId() => !String.IsNullOrEmpty(AnnotationId);
  public bool ShouldSerializePreviousTableProperties() => PreviousTableProperties is not null && ShouldSerialize(PreviousTableProperties);
}
