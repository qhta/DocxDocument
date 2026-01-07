namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the RegionLabelLayoutEnum enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RegionLabelLayoutEnum
{
  /// <summary>
  ///   none.
  /// </summary>
  None,
  /// <summary>
  ///   bestFitOnly.
  /// </summary>
  BestFitOnly,
  /// <summary>
  ///   showAll.
  /// </summary>
  ShowAll
}