namespace DocumentModel.Wordprocessing;
/// <summary>
///   Specifies on/off values used in Office 2010+ features.
/// </summary>
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Office2010.Word.OnOffValues))]
public enum OnOffKind
{
  /// <summary>
  /// true.
  /// <para>When the item is serialized out as xml, its value is "true".</para>
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.OnOffValues.True))]
  True,
  /// <summary>
  /// false.
  /// <para>When the item is serialized out as xml, its value is "false".</para>
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.OnOffValues.False))]
  False,
  /// <summary>
  /// 0.
  /// <para>When the item is serialized out as xml, its value is "0".</para>
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.OnOffValues.Zero))]
  Zero,
  /// <summary>
  /// 1.
  /// <para>When the item is serialized out as xml, its value is "1".</para>
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Office2010.Word.OnOffValues.One))]
  One,
}