namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the base reference point used for positioning absolute tabs in a document.
/// </summary>
/// <remarks>Use this enumeration to indicate whether absolute tab positions are measured from the page margin or
/// from the current indentation level. This affects how tab stops are calculated and rendered in formatted
/// text.</remarks>
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues))]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AbsolutePositionTabPositioningBaseValues
{
  /// <summary>
  /// Absolute tab positions are measured from the page margin. 
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues.Margin))]
  Margin,
  /// <summary>
  /// Absolute tab positions are measured from the current indentation level. 
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.AbsolutePositionTabPositioningBaseValues.Indent))]
  Indent,
}