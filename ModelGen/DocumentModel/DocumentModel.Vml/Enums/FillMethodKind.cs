namespace DocumentModel.Vml;

/// <summary>
/// Gradient Fill Computation Type
/// </summary>
public enum FillMethodKind
{
  /// <summary>
  /// No Gradient Fill.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Linear Fill.
  /// </summary>
  [XmlEnum("linear")]
  Linear,
  
  /// <summary>
  /// Sigma Fill.
  /// </summary>
  [XmlEnum("sigma")]
  Sigma,
  
  /// <summary>
  /// Application Default Fill.
  /// </summary>
  [XmlEnum("any")]
  Any,
  
  /// <summary>
  /// Linear Sigma Fill.
  /// </summary>
  [XmlEnum("linear sigma")]
  Linearsigma,
  
}
