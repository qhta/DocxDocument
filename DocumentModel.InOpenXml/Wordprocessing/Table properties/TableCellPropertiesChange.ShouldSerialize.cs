namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableCellPropertiesChange
{
  public bool ShouldSerializeAnnotationId() => !String.IsNullOrEmpty(AnnotationId);
  public bool ShouldSerializePreviousTableCellProperties() => PreviousTableCellProperties is not null;
}
