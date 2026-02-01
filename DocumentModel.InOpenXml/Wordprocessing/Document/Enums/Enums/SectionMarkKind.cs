namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the SectionMarkValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.SectionMarkValues))]
public enum SectionMarkKind
{
  /// <summary>
  ///   Next Page ISection Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.SectionMarkValues.NextPage))]
  NextPage,
  /// <summary>
  ///   IColumn ISection Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.SectionMarkValues.NextColumn))]
  NextColumn,
  /// <summary>
  ///   Continuous ISection Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.SectionMarkValues.Continuous))]
  Continuous,
  /// <summary>
  ///   Even Page ISection Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.SectionMarkValues.EvenPage))]
  EvenPage,
  /// <summary>
  ///   Odd Page ISection Break.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.SectionMarkValues.OddPage))]
  OddPage
}