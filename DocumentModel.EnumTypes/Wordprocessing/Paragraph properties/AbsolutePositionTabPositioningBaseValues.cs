namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the base reference point used for positioning absolute tabs in a document.
/// </summary>
/// <remarks>Use this enumeration to indicate whether absolute tab positions are measured from the page margin or
/// from the current indentation level. This affects how tab stops are calculated and rendered in formatted
/// text.</remarks>
[OpenXmlEnumType(typeof(DXW.AbsolutePositionTabPositioningBaseValues))]
[JsonConverter(typeof(StringEnumConverter))]
public enum AbsolutePositionTabPositioningBaseValues
{
  /// <summary>
  /// Absolute tab positions are measured from the page margin. 
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabPositioningBaseValues.Margin))]
  Margin,
  /// <summary>
  /// Absolute tab positions are measured from the current indentation level. 
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.AbsolutePositionTabPositioningBaseValues.Indent))]
  Indent,
}