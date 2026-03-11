namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the MergedCellValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.MergedCellValues))]
public enum MergedCell
{
  /// <summary>
  ///   Continue Merged Region.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MergedCellValues.Continue))]
  Continue,
  /// <summary>
  ///   Start/Restart Merged Region.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.MergedCellValues.Restart))]
  Restart
}