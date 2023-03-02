namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DataLabelFieldTable Class.
/// </summary>
public record DataLabelFieldTable
{
  public Collection<DataLabelFieldTableEntry>? DataLabelFieldTableEntries { get; set; }
}