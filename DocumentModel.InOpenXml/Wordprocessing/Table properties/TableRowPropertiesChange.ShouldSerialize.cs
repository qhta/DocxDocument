namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class TableRowPropertiesChange
{
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTableRowProperties() => PreviousTableRowProperties is not null;
}
