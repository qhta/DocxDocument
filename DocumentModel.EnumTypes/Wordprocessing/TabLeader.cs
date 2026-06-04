namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TabLeader enumeration.
/// Used in types such as Index, TableOfAuthorities, TableOfContents.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TabLeader
{
  /// <summary>No leader</summary>
  [OpenXmlEnumValue("None")]
  None = 0,
  /// <summary>Dotted leader</summary>
  [OpenXmlEnumValue("Dots")]
  Dots = 1,
  /// <summary>Dashed leader</summary>
  [OpenXmlEnumValue("Dashes")]
  Dashes = 2,
  /// <summary>Solid line leader</summary>
  [OpenXmlEnumValue("Line")]
  Line = 3,
  /// <summary>Heavy line leader</summary>
  [OpenXmlEnumValue("Heavy")]
  Heavy = 4,
  /// <summary>Middle dot leader</summary>
  [OpenXmlEnumValue("MiddleDot")]
  MiddleDot = 5
}
