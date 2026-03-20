using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextRange2` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2?view=office-pia
/// </remarks>
public partial interface TextRange2: InteropDictionary<string, TextRange2>
{
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.text?view=office-pia
  /// </remarks>
  public string Text { get; set; }
  /// <summary>
  /// Gets the `Paragraphs` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.paragraphs?view=office-pia
  /// </remarks>
  public TextRange2 Paragraphs { get; }
  /// <summary>
  /// Gets the `Sentences` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.sentences?view=office-pia
  /// </remarks>
  public TextRange2 Sentences { get; }
  /// <summary>
  /// Gets the `Words` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.words?view=office-pia
  /// </remarks>
  public TextRange2 Words { get; }
  /// <summary>
  /// Gets the `Characters` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.characters?view=office-pia
  /// </remarks>
  public TextRange2 Characters { get; }
  /// <summary>
  /// Gets the `Lines` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.lines?view=office-pia
  /// </remarks>
  public TextRange2 Lines { get; }
  /// <summary>
  /// Gets the `Runs` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.runs?view=office-pia
  /// </remarks>
  public TextRange2 Runs { get; }
  /// <summary>
  /// Gets the `ParagraphFormat` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.paragraphformat?view=office-pia
  /// </remarks>
  public ParagraphFormat2 ParagraphFormat { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.font?view=office-pia
  /// </remarks>
  public Font2 Font { get; }
  /// <summary>
  /// Gets the `Length` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.length?view=office-pia
  /// </remarks>
  public int Length { get; }
  /// <summary>
  /// Gets the `Start` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.start?view=office-pia
  /// </remarks>
  public int Start { get; }
  /// <summary>
  /// Gets the `BoundLeft` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.boundleft?view=office-pia
  /// </remarks>
  public float BoundLeft { get; }
  /// <summary>
  /// Gets the `BoundTop` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.boundtop?view=office-pia
  /// </remarks>
  public float BoundTop { get; }
  /// <summary>
  /// Gets the `BoundWidth` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.boundwidth?view=office-pia
  /// </remarks>
  public float BoundWidth { get; }
  /// <summary>
  /// Gets the `BoundHeight` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.boundheight?view=office-pia
  /// </remarks>
  public float BoundHeight { get; }
  /// <summary>
  /// Gets or sets the `LanguageID` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.languageid?view=office-pia
  /// </remarks>
  public MsoLanguageID LanguageID { get; set; }
  /// <summary>
  /// Gets the `MathZones` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.mathzones?view=office-pia
  /// </remarks>
  public TextRange2 MathZones { get; }
}
