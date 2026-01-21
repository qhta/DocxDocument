namespace DocumentModel.Wordprocessing;

public partial class TableGridChange
{
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTableGrid() => PreviousTableGrid is not null;
}
