namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableGridChange
{
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTableGrid() => PreviousTableGrid is not null;
}
