namespace DocumentModel.Drawings.Diagrams;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Function Operator
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FunctionOperatorKind
{
  /// <summary>
  ///   Equal.
  /// </summary>
  Equal,

  /// <summary>
  ///   Not Equal To.
  /// </summary>
  NotEqualTo,

  /// <summary>
  ///   Greater Than.
  /// </summary>
  GreaterThan,

  /// <summary>
  ///   Less Than.
  /// </summary>
  LessThan,

  /// <summary>
  ///   Greater Than or Equal to.
  /// </summary>
  GreaterThanOrEqualTo,

  /// <summary>
  ///   Less Than or Equal to.
  /// </summary>
  LessThanOrEqualTo
}