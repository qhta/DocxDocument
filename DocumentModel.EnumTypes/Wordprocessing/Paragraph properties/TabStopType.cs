namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TabStopValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TabStopValues))]
public enum TabStopType
{
  /// <summary>
  ///   No Tab Stop.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopValues.Clear))]
  Clear,
  /// <summary>
  ///   Left Tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopValues.Left))]
  Left,
  /// <summary>
  ///   start.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopValues.Start))]
  Start,
  /// <summary>
  ///   Centered Tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopValues.Center))]
  Center,
  /// <summary>
  ///   Right Tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopValues.Right))]
  Right,
  /// <summary>
  ///   end.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopValues.End))]
  End,
  /// <summary>
  ///   Decimal Tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopValues.Decimal))]
  Decimal,
  /// <summary>
  ///   Bar Tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopValues.Bar))]
  Bar,
  /// <summary>
  ///   List Tab.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TabStopValues.Number))]
  Number
}