namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the DataLabelHidden Class.
/// </summary>
public record DataLabelHidden
{
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Idx { get; set; }
}