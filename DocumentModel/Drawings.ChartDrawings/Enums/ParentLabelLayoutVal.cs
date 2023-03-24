namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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