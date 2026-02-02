namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the VerticalMergeRevisionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.VerticalMergeRevisionValues))]
public enum VerticalMergeRevision
{
  /// <summary>
  ///   Vertically Merged Cell.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalMergeRevisionValues.Continue))]
  Continue,
  /// <summary>
  ///   Vertically Split Cell.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalMergeRevisionValues.Restart))]
  Restart
}