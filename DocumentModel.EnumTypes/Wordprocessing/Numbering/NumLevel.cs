namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering level enumeration for numbering in WordprocessingML documents.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NumLevel
{
  /// <summary>
  /// Represents the first level in an outline hierarchy, typically assigned to Header1.
  /// </summary>
  Level1 = 0,

  /// <summary>
  /// Represents the second level in an outline hierarchy, typically assigned to Header2.
  /// </summary>
  Level2 = 1,

  /// <summary>
  /// Represents the third level in an outline hierarchy.
  /// </summary>
  Level3 = 2,

  /// <summary>
  /// Represents the fourth level in an outline hierarchy.
  /// </summary>
  Level4 = 3,

  /// <summary>
  /// Represents the fifth level in an outline hierarchy.
  /// </summary>
  Level5 = 4,

  /// <summary>
  /// Represents the sixth level in an outline hierarchy.
  /// </summary>
  Level6 = 5,

  /// <summary>
  /// Represents the seventh level in an outline hierarchy.
  /// </summary>
  Level7 = 6,

  /// <summary>
  /// Represents the eighth level in an outline hierarchy.
  /// </summary>
  Level8 = 7,

  /// <summary>
  /// Represents the ninth level in an outline hierarchy.
  /// </summary>
  Level9 = 9,
}