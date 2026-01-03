namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DataLabelFieldTable Class.
/// </summary>
public interface DataLabelFieldTable: IModelElement
{
  public Collection<DataLabelFieldTableEntry>? DataLabelFieldTableEntries { get; set; }
}