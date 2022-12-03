namespace DocumentModel.Drawings;

/// <summary>
/// Built-In Unit
/// </summary>
public enum BuiltInUnitKind
{
  /// <summary>
  /// Hundreds.
  /// </summary>
  [XmlEnum("hundreds")]
  Hundreds,
  
  /// <summary>
  /// Thousands.
  /// </summary>
  [XmlEnum("thousands")]
  Thousands,
  
  /// <summary>
  /// Ten Thousands.
  /// </summary>
  [XmlEnum("tenThousands")]
  TenThousands,
  
  /// <summary>
  /// Hundred Thousands.
  /// </summary>
  [XmlEnum("hundredThousands")]
  HundredThousands,
  
  /// <summary>
  /// Millions.
  /// </summary>
  [XmlEnum("millions")]
  Millions,
  
  /// <summary>
  /// Ten Millions.
  /// </summary>
  [XmlEnum("tenMillions")]
  TenMillions,
  
  /// <summary>
  /// Hundred Millions.
  /// </summary>
  [XmlEnum("hundredMillions")]
  HundredMillions,
  
  /// <summary>
  /// Billions.
  /// </summary>
  [XmlEnum("billions")]
  Billions,
  
  /// <summary>
  /// Trillions.
  /// </summary>
  [XmlEnum("trillions")]
  Trillions,
  
}
