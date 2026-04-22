namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class RunPropertiesChange
{
  public bool ShouldSerializeAnnotationId() => !String.IsNullOrEmpty(AnnotationId);
  public bool ShouldSerializePreviousRunProperties() => PreviousRunProperties is not null;
}
