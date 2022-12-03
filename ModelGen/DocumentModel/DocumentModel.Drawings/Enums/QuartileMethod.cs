namespace DocumentModel.Drawings;

/// <summary>
/// Defines the QuartileMethod enumeration.
/// </summary>
public enum QuartileMethod
{
  /// <summary>
  /// inclusive.
  /// </summary>
  [XmlEnum("inclusive")]
  Inclusive,
  
  /// <summary>
  /// exclusive.
  /// </summary>
  [XmlEnum("exclusive")]
  Exclusive,
  
}
