namespace DocumentModel.Wordprocessing;

public partial class TableCellPropertiesChange
{
  public bool ShouldSerializeAuthor() => Author is not null;
  public bool ShouldSerializeDate() => Date is not null;
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTableCellProperties() => PreviousTableCellProperties is not null;
}
