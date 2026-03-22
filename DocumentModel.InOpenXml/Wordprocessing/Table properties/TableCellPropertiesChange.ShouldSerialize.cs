namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class TableCellPropertiesChange
{
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTableCellProperties() => PreviousTableCellProperties is not null;
}
