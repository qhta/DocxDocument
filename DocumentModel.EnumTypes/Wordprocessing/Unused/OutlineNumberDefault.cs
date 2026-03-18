namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the OutlineNumberDefault enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum OutlineNumberDefault
{
  /// <summary>Arabic outline numbering (1., 1.1., 1.1.1...)</summary>
  [OpenXmlEnumValue("Arabic")]
  Arabic = 0,
  /// <summary>Chapter outline (Chapter 1, 1.1, 1.1.1...)</summary>
  [OpenXmlEnumValue("Chapter")]
  Chapter = 1,
  /// <summary>Article outline (Article I, Section 1.01...)</summary>
  [OpenXmlEnumValue("Article")]
  Article = 2,
  /// <summary>Legal outline (1., 1.1, 1.1.1...)</summary>
  [OpenXmlEnumValue("Legal")]
  Legal = 3
}
