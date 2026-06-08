namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   IShape Grouping Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum EditAsKind
{
  /// <summary>
  ///   IShape Canvas.
  /// </summary>
  Canvas,

  /// <summary>
  ///   Organization IChart IDiagram.
  /// </summary>
  OrganizationChart,

  /// <summary>
  ///   Radial IDiagram.
  /// </summary>
  Radial,

  /// <summary>
  ///   Cycle IDiagram.
  /// </summary>
  Cycle,

  /// <summary>
  ///   Pyramid IDiagram.
  /// </summary>
  Stacked,

  /// <summary>
  ///   Venn IDiagram.
  /// </summary>
  Venn,

  /// <summary>
  ///   Bullseye IDiagram.
  /// </summary>
  Bullseye
}
