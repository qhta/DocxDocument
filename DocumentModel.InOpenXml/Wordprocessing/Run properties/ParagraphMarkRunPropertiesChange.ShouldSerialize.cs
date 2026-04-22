namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ParagraphMarkRunPropertiesChange
{
  public bool ShouldSerializeAnnotationId() => !String.IsNullOrEmpty(AnnotationId);
  public bool ShouldSerializePreviousParagraphMarkRunProperties() => PreviousParagraphMarkRunProperties is not null;
}
