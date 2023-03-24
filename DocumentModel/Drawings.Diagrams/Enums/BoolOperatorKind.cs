namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Boolean Constraint
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BoolOperatorKind
{
  /// <summary>
  ///   None.
  /// </summary>
  None,

  /// <summary>
  ///   Equal.
  /// </summary>
  Equal,

  /// <summary>
  ///   Greater Than or Equal to.
  /// </summary>
  GreaterThanOrEqualTo,

  /// <summary>
  ///   Less Than or Equal to.
  /// </summary>
  LessThanOrEqualTo
}