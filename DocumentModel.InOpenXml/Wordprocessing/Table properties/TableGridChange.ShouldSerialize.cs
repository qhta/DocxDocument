namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class TableGridChange
{
  public bool ShouldSerializeAnnotationId() => !String.IsNullOrEmpty(AnnotationId);
  public bool ShouldSerializePreviousTableGrid() => PreviousTableGrid is not null && ShouldSerialize(PreviousTableGrid);
}
