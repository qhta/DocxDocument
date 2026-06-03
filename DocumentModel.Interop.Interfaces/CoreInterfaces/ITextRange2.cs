using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextRange2` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2?view=office-pia"/>
public interface ITextRange2: IInteropCollection<ITextRange2>
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
  public ITextRange2 Paragraphs { get; }
  /// <summary>
  /// Gets the `Sentences` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.sentences?view=office-pia"/>
  public ITextRange2 Sentences { get; }
  /// <summary>
  /// Gets the `Words` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.words?view=office-pia"/>
  public ITextRange2 Words { get; }
  /// <summary>
  /// Gets the `Characters` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.characters?view=office-pia"/>
  public ITextRange2 Characters { get; }
  /// <summary>
  /// Gets the `Lines` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.lines?view=office-pia"/>
  public ITextRange2 Lines { get; }
  /// <summary>
  /// Gets the `Runs` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.runs?view=office-pia"/>
  public ITextRange2 Runs { get; }
  /// <summary>
  /// Gets the `ParagraphFormat` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.paragraphformat?view=office-pia"/>
  public IParagraphFormat2 ParagraphFormat { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.font?view=office-pia"/>
  public IFont2 Font { get; }
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
  public ITextRange2 MathZones { get; }


  #region methods

/// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.item?view=office-pia"/>
  public ITextRange2 Item(object index);
  /// <summary>
  /// Invokes `TrimText`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.trimtext?view=office-pia"/>
  public ITextRange2 TrimText();
  /// <summary>
  /// Invokes `InsertAfter`.
  /// </summary>
  /// <param name="newText">The `NewText` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertafter?view=office-pia"/>
  public ITextRange2 InsertAfter(string newText);
  /// <summary>
  /// Invokes `InsertBefore`.
  /// </summary>
  /// <param name="newText">The `NewText` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertbefore?view=office-pia"/>
  public ITextRange2 InsertBefore(string newText);
  /// <summary>
  /// Invokes `InsertSymbol`.
  /// </summary>
  /// <param name="fontName">The `Name` parameter.</param>
  /// <param name="charNumber">The `CharNumber` parameter.</param>
  /// <param name="unicode">The `Unicode` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertsymbol?view=office-pia"/>
  public ITextRange2 InsertSymbol(string fontName, int charNumber, TriState unicode);
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.select?view=office-pia"/>
  public void Select();
  /// <summary>
  /// Invokes `Cut`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.cut?view=office-pia"/>
  public void Cut();
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.copy?view=office-pia"/>
  public void Copy();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.delete?view=office-pia"/>
  public void Delete();
  /// <summary>
  /// Invokes `Paste`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.paste?view=office-pia"/>
  public ITextRange2 Paste();
  /// <summary>
  /// Invokes `PasteSpecial`.
  /// </summary>
  /// <param name="format">The `Format` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.pastespecial?view=office-pia"/>
  public ITextRange2 PasteSpecial(ClipboardFormat format);
  /// <summary>
  /// Invokes `ChangeCase`.
  /// </summary>
  /// <param name="type">The `Type` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.changecase?view=office-pia"/>
  public void ChangeCase(TextChangeCase type);
  /// <summary>
  /// Invokes `AddPeriods`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.addperiods?view=office-pia"/>
  public void AddPeriods();
  /// <summary>
  /// Invokes `RemovePeriods`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.removeperiods?view=office-pia"/>
  public void RemovePeriods();
  /// <summary>
  /// Invokes `Find`.
  /// </summary>
  /// <param name="FindWhat">The `FindWhat` parameter.</param>
  /// <param name="After">The `After` parameter.</param>
  /// <param name="MatchCase">The `MatchCase` parameter.</param>
  /// <param name="WholeWords">The `WholeWords` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.find?view=office-pia"/>
  public ITextRange2 Find
  (string FindWhat, int After, TriState MatchCase,
    TriState WholeWords);
  /// <summary>
  /// Invokes `Replace`.
  /// </summary>
  /// <param name="FindWhat">The `FindWhat` parameter.</param>
  /// <param name="ReplaceWhat">The `ReplaceWhat` parameter.</param>
  /// <param name="After">The `After` parameter.</param>
  /// <param name="MatchCase">The `MatchCase` parameter.</param>
  /// <param name="WholeWords">The `WholeWords` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.replace?view=office-pia"/>
  public ITextRange2 Replace
  (string FindWhat, string ReplaceWhat, int After, TriState MatchCase,
    TriState WholeWords);
  /// <summary>
  /// Invokes `RotatedBounds`.
  /// </summary>
  /// <param name="X1">The `X1` parameter.</param>
  /// <param name="Y1">The `Y1` parameter.</param>
  /// <param name="X2">The `X2` parameter.</param>
  /// <param name="Y2">The `Y2` parameter.</param>
  /// <param name="X3">The `X3` parameter.</param>
  /// <param name="Y3">The `Y3` parameter.</param>
  /// <param name="x4">The `x4` parameter.</param>
  /// <param name="y4">The `y4` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.rotatedbounds?view=office-pia"/>
  public void RotatedBounds
    (out float X1, out float Y1, out float X2, out float Y2, out float X3, out float Y3, out float x4, out float y4);
  /// <summary>
  /// Invokes `RtlRun`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.rtlrun?view=office-pia"/>
  public void RtlRun();
  /// <summary>
  /// Invokes `LtrRun`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.ltrrun?view=office-pia"/>
  public void LtrRun();
  /// <summary>
  /// Invokes `InsertChartField`.
  /// </summary>
  /// <param name="chartFieldType">The `ChartFieldType` parameter.</param>
  /// <param name="formula">The `Formula` parameter.</param>
  /// <param name="position">The `Position` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertchartfield?view=office-pia"/>
  public ITextRange2 InsertChartField(ChartFieldType chartFieldType, string formula, int position);

  #endregion methods
}

