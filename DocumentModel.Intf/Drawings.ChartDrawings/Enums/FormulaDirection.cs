namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FormulaDirection enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FormulaDirection
{
  /// <summary>
  ///   col.
  /// </summary>
  Col,

  /// <summary>
  ///   row.
  /// </summary>
  Row
}