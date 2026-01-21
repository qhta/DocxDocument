namespace DocumentModel.Wordprocessing;

public partial class TableRowPropertiesChange
{
  public bool ShouldSerializeAuthor() => Author is not null;
  public bool ShouldSerializeDate() => Date is not null;
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTableRowProperties() => PreviousTableRowProperties is not null;
}
