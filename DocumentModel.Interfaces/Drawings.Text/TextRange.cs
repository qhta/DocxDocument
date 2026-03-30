using System.Collections;
using System.Reflection;

namespace DocumentModel.Drawings.Text;

/// <summary>
/// Represents the `TextRange2` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2?view=office-pia"/>
public partial interface TextRange: IModelObject, IModelCollection<TextRange>
{
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.text?view=office-pia"/>
  public string Text { get; set; }
  /// <summary>
  /// Gets the `Paragraphs` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.paragraphs?view=office-pia"/>
  public TextRange Paragraphs { get; }
  /// <summary>
  /// Gets the `Sentences` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.sentences?view=office-pia"/>
  public TextRange Sentences { get; }
  /// <summary>
  /// Gets the `Words` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.words?view=office-pia"/>
  public TextRange Words { get; }
  /// <summary>
  /// Gets the `Characters` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.characters?view=office-pia"/>
  public TextRange Characters { get; }
  /// <summary>
  /// Gets the `Lines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.lines?view=office-pia"/>
  public TextRange Lines { get; }
  /// <summary>
  /// Gets the `Runs` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.runs?view=office-pia"/>
  public TextRange Runs { get; }
  /// <summary>
  /// Gets the `ParagraphFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.paragraphformat?view=office-pia"/>
  public ParagraphFormat2 ParagraphFormat { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.font?view=office-pia"/>
  public Font Font { get; }
  /// <summary>
  /// Gets the `Length` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.length?view=office-pia"/>
  public int Length { get; }
  /// <summary>
  /// Gets the `Start` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.start?view=office-pia"/>
  public int Start { get; }
  /// <summary>
  /// Gets the `BoundLeft` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.boundleft?view=office-pia"/>
  public float BoundLeft { get; }
  /// <summary>
  /// Gets the `BoundTop` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.boundtop?view=office-pia"/>
  public float BoundTop { get; }
  /// <summary>
  /// Gets the `BoundWidth` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.boundwidth?view=office-pia"/>
  public float BoundWidth { get; }
  /// <summary>
  /// Gets the `BoundHeight` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.boundheight?view=office-pia"/>
  public float BoundHeight { get; }
  /// <summary>
  /// Gets or sets the `LanguageID` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.languageid?view=office-pia"/>
  public LanguageID LanguageID { get; set; }
  /// <summary>
  /// Gets the `MathZones` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.mathzones?view=office-pia"/>
  public TextRange MathZones { get; }
}

