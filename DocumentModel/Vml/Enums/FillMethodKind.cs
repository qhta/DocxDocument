namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Gradient Fill Computation Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
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
  ///   IApplication Default Fill.
  /// </summary>
  Any,

  /// <summary>
  ///   Linear Sigma Fill.
  /// </summary>
  Linearsigma
}
