namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the DataLabelsPosition enumeration.
/// </summary>
public enum DataLabelsPosition
{
  /// <summary>
  /// center.
  /// </summary>
  [XmlEnum("center")]
  Center,
  
  /// <summary>
  /// insideEnd.
  /// </summary>
  [XmlEnum("insideEnd")]
  InsideEnd,
  
  /// <summary>
  /// insideBase.
  /// </summary>
  [XmlEnum("insideBase")]
  InsideBase,
  
  /// <summary>
  /// outsideEnd.
  /// </summary>
  [XmlEnum("outsideEnd")]
  OutsideEnd,
  
  /// <summary>
  /// ninch.
  /// </summary>
  [XmlEnum("ninch")]
  Ninch,
  
}
