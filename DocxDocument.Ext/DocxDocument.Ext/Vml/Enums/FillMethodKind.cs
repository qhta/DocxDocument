namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Gradient Fill Computation Type
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum FillMethodKind
{
  /// <summary>
  ///   No Gradient Fill.
  /// </summary>
  None,

  /// <summary>
  ///   Linear Fill.
  /// </summary>
  Linear,

  /// <summary>
  ///   Sigma Fill.
  /// </summary>
  Sigma,

  /// <summary>
  ///   Application Default Fill.
  /// </summary>
  Any,

  /// <summary>
  ///   Linear Sigma Fill.
  /// </summary>
  Linearsigma
}