namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of axis identifiers for a chart.
///   Each identifier in the collection corresponds to a unique axis within the chart, allowing for the association and management of multiple axes (such as category, value, or series axes).
///   This class is typically used to link chart elements to their respective axes by ID.
/// </summary>
public class AxisIds : ValueCollection<UInt32>
{
}