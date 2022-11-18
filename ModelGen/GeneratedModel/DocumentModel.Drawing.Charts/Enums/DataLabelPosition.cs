namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Data Label Position
/// </summary>
public enum DataLabelPosition
{
  /// <summary>
  /// Best Fit.
  /// </summary>
  [XmlEnum("bestFit")]
  BestFit,
  
  /// <summary>
  /// Bottom.
  /// </summary>
  [XmlEnum("b")]
  Bottom,
  
  /// <summary>
  /// Center.
  /// </summary>
  [XmlEnum("ctr")]
  Center,
  
  /// <summary>
  /// Inside Base.
  /// </summary>
  [XmlEnum("inBase")]
  InsideBase,
  
  /// <summary>
  /// Inside End.
  /// </summary>
  [XmlEnum("inEnd")]
  InsideEnd,
  
  /// <summary>
  /// Left.
  /// </summary>
  [XmlEnum("l")]
  Left,
  
  /// <summary>
  /// Outside End.
  /// </summary>
  [XmlEnum("outEnd")]
  OutsideEnd,
  
  /// <summary>
  /// Right.
  /// </summary>
  [XmlEnum("r")]
  Right,
  
  /// <summary>
  /// Top.
  /// </summary>
  [XmlEnum("t")]
  Top,
  
}
