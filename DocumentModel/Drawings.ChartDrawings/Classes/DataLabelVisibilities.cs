namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DataLabelVisibilities Class.
/// </summary>
public class DataLabelVisibilities: ModelElement
{
  /// <summary>
  ///   seriesName, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? SeriesName { get; set; }

  /// <summary>
  ///   categoryName, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? CategoryName { get; set; }

  /// <summary>
  ///   value, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? Value { get; set; }
}