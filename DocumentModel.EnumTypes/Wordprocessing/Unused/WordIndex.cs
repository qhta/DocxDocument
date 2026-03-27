namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Index enumeration.
/// Used in types such as DocumentCleaner.TableTools, Program, ArrayVariant.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum WordIndex
{
  /// <summary>Standard index</summary>
  [OpenXmlEnumValue("Standard")]
  Standard,
  /// <summary>Run-in index</summary>
  [OpenXmlEnumValue("RunIn")]
  RunIn,
  /// <summary>Formal index</summary>
  [OpenXmlEnumValue("Formal")]
  Formal,
  /// <summary>Simple index</summary>
  [OpenXmlEnumValue("Simple")]
  Simple,
  /// <summary>Fancy index</summary>
  [OpenXmlEnumValue("Fancy")]
  Fancy,
  /// <summary>Modern index</summary>
  [OpenXmlEnumValue("Modern")]
  Modern,
  /// <summary>Bulleted index</summary>
  [OpenXmlEnumValue("Bulleted")]
  Bulleted,
  /// <summary>Classic index</summary>
  [OpenXmlEnumValue("Classic")]
  Classic,
  /// <summary>Distinctive index</summary>
  [OpenXmlEnumValue("Distinctive")]
  Distinctive,
  /// <summary>Centered index</summary>
  [OpenXmlEnumValue("Centered")]
  Centered
}
