namespace DocumentModel.Vml;

/// <summary>
///   Gradient Fill Computation Type
/// </summary>
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