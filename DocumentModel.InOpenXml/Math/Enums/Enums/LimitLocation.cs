namespace DocumentModel.Math;
/// <summary>
///   Defines the LimitLocationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXM.LimitLocationValues))]
public enum LimitLocation
{
  /// <summary>
  ///   Under-Over location.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.LimitLocationValues.UnderOver))]
  UnderOver,
  /// <summary>
  ///   Subscript-Superscript location.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXM.LimitLocationValues.SubscriptSuperscript))]
  SubscriptSuperscript
}