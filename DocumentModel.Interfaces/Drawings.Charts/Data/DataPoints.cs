namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a collection of data points for a chart series.
///   Each <see cref="DataPoint"/> in the collection defines the value, formatting, and visual properties for a single entry in the chart, such as a bar, line, or marker.
///   This interface enables grouping and management of multiple data points within a chart series.
/// </summary>
public interface DataPoints: ElementCollection<DataPoint>
{
  
}