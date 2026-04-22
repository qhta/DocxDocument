namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableRowPropertiesChange
{
  public bool ShouldSerializeAnnotationId() => !String.IsNullOrEmpty(AnnotationId);
  public bool ShouldSerializePreviousTableRowProperties() => PreviousTableRowProperties is not null;
}
