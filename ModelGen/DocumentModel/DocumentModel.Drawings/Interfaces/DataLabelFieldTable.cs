namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabelFieldTable Class.
/// </summary>
public interface DataLabelFieldTable // : DocumentModel.BaseTypes.ModelElement
{
  public Collection<DataLabelFieldTableEntry>? DataLabelFieldTableEntries { get ; set; }
  
}
