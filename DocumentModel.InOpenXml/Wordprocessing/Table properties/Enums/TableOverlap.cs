namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TableOverlapValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TableOverlapValues))]
public enum TableOverlap
{
  /// <summary>
  ///   Floating Table Cannot Overlap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableOverlapValues.Never))]
  Never,
  /// <summary>
  ///   Floating Table Can Overlap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TableOverlapValues.Overlap))]
  Overlap
}