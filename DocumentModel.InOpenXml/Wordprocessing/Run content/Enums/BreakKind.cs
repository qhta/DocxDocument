namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the BreakValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.BreakValues))]
public enum BreakKind
{
  /// <summary>
  ///   Page Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BreakValues.Page))]
  Page,
  /// <summary>
  ///   IColumn Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BreakValues.Column))]
  Column,
  /// <summary>
  ///   Line Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.BreakValues.TextWrapping))]
  TextWrapping
}