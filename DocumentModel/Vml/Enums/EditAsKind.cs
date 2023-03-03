namespace DocumentModel.Vml;

/// <summary>
///   Shape Grouping Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum EditAsKind
{
  /// <summary>
  ///   Shape Canvas.
  /// </summary>
  Canvas,

  /// <summary>
  ///   Organization Chart Diagram.
  /// </summary>
  OrganizationChart,

  /// <summary>
  ///   Radial Diagram.
  /// </summary>
  Radial,

  /// <summary>
  ///   Cycle Diagram.
  /// </summary>
  Cycle,

  /// <summary>
  ///   Pyramid Diagram.
  /// </summary>
  Stacked,

  /// <summary>
  ///   Venn Diagram.
  /// </summary>
  Venn,

  /// <summary>
  ///   Bullseye Diagram.
  /// </summary>
  Bullseye
}