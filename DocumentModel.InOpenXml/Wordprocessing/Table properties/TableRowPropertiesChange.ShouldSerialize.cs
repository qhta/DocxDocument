namespace DocumentModel.Wordprocessing;

public partial class TableRowPropertiesChange
{
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTableRowProperties() => PreviousTableRowProperties is not null;
}
