namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the OnOff enumeration.
/// Used in types such as OnOffConverter, SimpleValueConverter, OnOffConverterTest.
/// </summary>
[OpenXmlEnumType(typeof(DXO10W.OnOffValues))]
[JsonConverter(typeof(StringEnumConverter))]
public enum OnOff
{
  /// <summary>
  /// true.
  /// <para>When the item is serialized out as xml, its value is "true".</para>
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.OnOffValues.True))]
  True,
  /// <summary>
  /// false.
  /// <para>When the item is serialized out as xml, its value is "false".</para>
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.OnOffValues.False))]
  False,
  /// <summary>
  /// 0.
  /// <para>When the item is serialized out as xml, its value is "0".</para>
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.OnOffValues.Zero))]
  Zero,
  /// <summary>
  /// 1.
  /// <para>When the item is serialized out as xml, its value is "1".</para>
  /// </summary>
  [OpenXmlEnumValue(nameof(DXO10W.OnOffValues.One))]
  One,
}
