namespace DocumentModel.Wordprocessing;

public partial class RunPropertiesChange
{
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousRunProperties() => PreviousRunProperties is not null;
}
