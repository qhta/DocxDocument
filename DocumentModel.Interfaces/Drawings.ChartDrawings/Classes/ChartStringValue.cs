namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Represents a string value associated with a specific index position in chart data.
/// </summary>
/// <remarks>
///   This interface extends <see cref="IModelElement"/> and defines a string value element that is positioned
///   at a specific index within a chart data series or category collection. Chart string values are typically
///   used for category labels, data point labels, or series names that need to be associated with a particular
///   position in the data structure. The index-based approach allows for sparse data representations where not
///   every position needs a value, and enables explicit ordering of string values regardless of insertion order.
///   This is particularly useful in chart scenarios where string labels need to align with specific data points
///   or categories, such as custom category names, data point annotations, or series identifiers. The indexed
///   structure supports efficient lookup and modification of string values at specific positions within the
///   chart's data model.
/// </remarks>
public interface ChartStringValue : IModelElement
{
  /// <summary>
  ///   Gets or sets the zero-based index position of this string value within its collection.
  /// </summary>
  /// <remarks>
   ///   The index determines the position of this string value within its parent collection, such as a
  ///   category axis labels collection or a data series labels collection. The index is zero-based,
  ///   meaning the first position is 0, the second is 1, and so on. This allows the string value to
  ///   be precisely positioned to correspond with specific data points, categories, or series elements
  ///   in the chart. The indexed approach enables sparse collections where not every index position
  ///   requires a string value, and supports efficient updates to specific positions without affecting
  ///   other values.
  /// </remarks>
  public UInt32? Index { get; set; }
}