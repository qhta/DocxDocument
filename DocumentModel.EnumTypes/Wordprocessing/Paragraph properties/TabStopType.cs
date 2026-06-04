namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TabStopValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.TabStopValues))]
public enum TabStopType
{
  /// <summary>
  ///   No Tab Stop.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopValues.Clear))]
  Clear = 1,

  /// <summary>
  ///   Left Tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopValues.Left))]
  Left,
  /// <summary>
  ///   start.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopValues.Start))]
  Start,
  /// <summary>
  ///   Centered Tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopValues.Center))]
  Center,
  /// <summary>
  ///   Right Tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopValues.Right))]
  Right,
  /// <summary>
  ///   end.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopValues.End))]
  End,
  /// <summary>
  ///   Decimal Tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopValues.Decimal))]
  Decimal,
  /// <summary>
  ///   Bar Tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopValues.Bar))]
  Bar,
  /// <summary>
  ///   List Tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.TabStopValues.Number))]
  Number
}