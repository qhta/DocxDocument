namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the NumberFormValues enumeration.
/// </summary>
public enum NumberForm
{
  /// <summary>
  /// default.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// lining.
  /// </summary>
  [XmlEnum("lining")]
  Lining,
  
  /// <summary>
  /// oldStyle.
  /// </summary>
  [XmlEnum("oldStyle")]
  OldStyle,
  
}
