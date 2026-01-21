namespace DocumentModel.Wordprocessing;

public partial class RunPropertiesChange
{
  public bool ShouldSerializeAuthor() => Author is not null;
  public bool ShouldSerializeDate() => Date is not null;
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousRunProperties() => PreviousRunProperties is not null;
}
