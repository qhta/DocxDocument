namespace DocumentModel.Wordprocessing;

public partial class TablePropertyExceptionsChange
{
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTablePropertyExceptions() => PreviousTablePropertyExceptions is not null;
}
