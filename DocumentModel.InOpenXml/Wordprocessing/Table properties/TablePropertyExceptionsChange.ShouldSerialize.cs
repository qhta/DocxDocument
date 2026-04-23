namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TablePropertyExceptionsChange
{
  public bool ShouldSerializeAnnotationId() => !String.IsNullOrEmpty(AnnotationId);
  public bool ShouldSerializePreviousTablePropertyExceptions() => PreviousTablePropertyExceptions is not null && ShouldSerialize(PreviousTablePropertyExceptions);
}
