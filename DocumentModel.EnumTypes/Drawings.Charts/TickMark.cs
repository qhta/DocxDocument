namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the TickMark enumeration.
/// Used in types such as AxisType.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.Charts.TickMarkValues))]
public enum TickMark
{
  /// <summary>
  ///   Cross.
  /// </summary>
  [OpenXmlEnumValue("Cross")]
  Cross,
  /// <summary>
  ///   Inside.
  /// </summary>
  [OpenXmlEnumValue("Inside")]
  Inside,
  /// <summary>
  ///   None.
  /// </summary>
  [OpenXmlEnumValue("None")]
  None,
  /// <summary>
  ///   Outside.
  /// </summary>
  [OpenXmlEnumValue("Outside")]
  Outside
}

