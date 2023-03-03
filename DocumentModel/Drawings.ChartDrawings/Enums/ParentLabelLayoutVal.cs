namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the ParentLabelLayoutVal enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ParentLabelLayoutVal
{
  /// <summary>
  ///   none.
  /// </summary>
  None,

  /// <summary>
  ///   banner.
  /// </summary>
  Banner,

  /// <summary>
  ///   overlapping.
  /// </summary>
  Overlapping
}