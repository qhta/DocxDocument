namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the outline level to apply to a paragraph.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdoutlinelevel?view=office-pia` for Office interop details.
/// </remarks>
public enum OutlineLevel
{
  /// <summary>
  /// Specifies the outline level 1 to apply to a paragraph.
  /// </summary>
  Level1 = 1,
  /// <summary>
  /// Specifies the outline level 2 to apply to a paragraph.
  /// </summary>
  Level2 = 2,
  /// <summary>
  /// Specifies the outline level 3 to apply to a paragraph.
  /// </summary>
  Level3 = 3,
  /// <summary>
  /// Specifies the outline level 4 to apply to a paragraph.
  /// </summary>
  Level4 = 4,
  /// <summary>
  /// Specifies the outline level 5 to apply to a paragraph.
  /// </summary>
  Level5 = 5,
  /// <summary>
  /// Specifies the outline level 6 to apply to a paragraph.
  /// </summary>
  Level6 = 6,
  /// <summary>
  /// Specifies the outline level 7 to apply to a paragraph.
  /// </summary>
  Level7 = 7,
  /// <summary>
  /// Specifies the outline level 8 to apply to a paragraph.
  /// </summary>
  Level8 = 8,
  /// <summary>
  /// Specifies the outline level 9 to apply to a paragraph.
  /// </summary>
  Level9 = 9,
  /// <summary>
  /// No outline level.
  /// </summary>
  BodyText = 10
}
