namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Hierarchy Branch Style Definition
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HierarchyBranchStyleKind
{
  /// <summary>
  ///   Left.
  /// </summary>
  Left,

  /// <summary>
  ///   Right.
  /// </summary>
  Right,

  /// <summary>
  ///   Hanging.
  /// </summary>
  Hanging,

  /// <summary>
  ///   Standard.
  /// </summary>
  Standard,

  /// <summary>
  ///   Initial.
  /// </summary>
  Initial
}