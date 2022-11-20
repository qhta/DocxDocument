namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the AxisUnit enumeration.
/// </summary>
public enum AxisUnit
{
  /// <summary>
  /// hundreds.
  /// </summary>
  [XmlEnum("hundreds")]
  Hundreds,
  
  /// <summary>
  /// thousands.
  /// </summary>
  [XmlEnum("thousands")]
  Thousands,
  
  /// <summary>
  /// tenThousands.
  /// </summary>
  [XmlEnum("tenThousands")]
  TenThousands,
  
  /// <summary>
  /// hundredThousands.
  /// </summary>
  [XmlEnum("hundredThousands")]
  HundredThousands,
  
  /// <summary>
  /// millions.
  /// </summary>
  [XmlEnum("millions")]
  Millions,
  
  /// <summary>
  /// tenMillions.
  /// </summary>
  [XmlEnum("tenMillions")]
  TenMillions,
  
  /// <summary>
  /// hundredMillions.
  /// </summary>
  [XmlEnum("hundredMillions")]
  HundredMillions,
  
  /// <summary>
  /// billions.
  /// </summary>
  [XmlEnum("billions")]
  Billions,
  
  /// <summary>
  /// trillions.
  /// </summary>
  [XmlEnum("trillions")]
  Trillions,
  
  /// <summary>
  /// percentage.
  /// </summary>
  [XmlEnum("percentage")]
  Percentage,
  
}
