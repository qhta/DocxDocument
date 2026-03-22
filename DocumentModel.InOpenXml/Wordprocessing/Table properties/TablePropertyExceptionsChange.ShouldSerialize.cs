namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class TablePropertyExceptionsChange
{
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTablePropertyExceptions() => PreviousTablePropertyExceptions is not null;
}
