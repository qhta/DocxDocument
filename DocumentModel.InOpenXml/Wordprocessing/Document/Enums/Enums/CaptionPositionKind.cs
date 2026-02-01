namespace DocumentModel.Wordprocessing;
/// <summary>
///   Automatic Caption Positioning Values
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.CaptionPositionValues))]
public enum CaptionPositionKind
{
  /// <summary>
  ///   Position Caption Above Object.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CaptionPositionValues.Above))]
  Above,
  /// <summary>
  ///   Position Caption Below Object.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.CaptionPositionValues.Below))]
  Below
}