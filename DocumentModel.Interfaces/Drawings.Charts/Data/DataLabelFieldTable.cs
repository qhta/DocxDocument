namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a table of data label field entries for a chart.
///   This interface provides a collection of <see cref="DataLabelFieldTableEntry"/> elements, each defining a field used in custom data labels.
///   The data label field table enables advanced customization of label content by specifying individual fields and their formatting.
/// </summary>
public interface DataLabelFieldTable: ElementCollection<DataLabelFieldTableEntry>
{
}