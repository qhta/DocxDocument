namespace DocumentModel.Wordprocessing;

public partial class TableCellPropertiesChange
{
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTableCellProperties() => PreviousTableCellProperties is not null;
}
