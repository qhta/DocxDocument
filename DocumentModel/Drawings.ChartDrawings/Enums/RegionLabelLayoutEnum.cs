namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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