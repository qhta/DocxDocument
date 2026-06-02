using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextRange2` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2?view=office-pia"/>
public partial class TextRange2: InteropCollection<TextRange2>
{
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.text?view=office-pia"/>
  public string Text { get; set; }
  /// <summary>
  /// Gets the `Paragraphs` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.paragraphs?view=office-pia"/>
  public TextRange2 Paragraphs { get; }
  /// <summary>
  /// Gets the `Sentences` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.sentences?view=office-pia"/>
  public TextRange2 Sentences { get; }
  /// <summary>
  /// Gets the `Words` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.words?view=office-pia"/>
  public TextRange2 Words { get; }
  /// <summary>
  /// Gets the `Characters` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.characters?view=office-pia"/>
  public TextRange2 Characters { get; }
  /// <summary>
  /// Gets the `Lines` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.lines?view=office-pia"/>
  public TextRange2 Lines { get; }
  /// <summary>
  /// Gets the `Runs` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.runs?view=office-pia"/>
  public TextRange2 Runs { get; }
  /// <summary>
  /// Gets the `ParagraphFormat` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.paragraphformat?view=office-pia"/>
  public ParagraphFormat2 ParagraphFormat { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.font?view=office-pia"/>
  public Font2 Font { get; }
  /// <summary>
  /// Gets the `Length` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.length?view=office-pia"/>
  public int Length { get; }
  /// <summary>
  /// Gets the `Start` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.start?view=office-pia"/>
  public int Start { get; }
  /// <summary>
  /// Gets the `BoundLeft` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.boundleft?view=office-pia"/>
  public float BoundLeft { get; }
  /// <summary>
  /// Gets the `BoundTop` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.boundtop?view=office-pia"/>
  public float BoundTop { get; }
  /// <summary>
  /// Gets the `BoundWidth` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.boundwidth?view=office-pia"/>
  public float BoundWidth { get; }
  /// <summary>
  /// Gets the `BoundHeight` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.boundheight?view=office-pia"/>
  public float BoundHeight { get; }
  /// <summary>
  /// Gets or sets the `LanguageID` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.languageid?view=office-pia"/>
  public LanguageID LanguageID { get; set; }
  /// <summary>
  /// Gets the `MathZones` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.mathzones?view=office-pia"/>
  public TextRange2 MathZones { get; }


  #region methods

/// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.item?view=office-pia"/>
  public TextRange2 Item(object Index) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `TrimText`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.trimtext?view=office-pia"/>
  public TextRange2 TrimText() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `InsertAfter`.
  /// </summary>
  /// <param name="NewText">The `NewText` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertafter?view=office-pia"/>
  public TextRange2 InsertAfter(string NewText) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `InsertBefore`.
  /// </summary>
  /// <param name="NewText">The `NewText` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertbefore?view=office-pia"/>
  public TextRange2 InsertBefore(string NewText) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `InsertSymbol`.
  /// </summary>
  /// <param name="FontName">The `FontName` parameter.</param>
  /// <param name="CharNumber">The `CharNumber` parameter.</param>
  /// <param name="Unicode">The `Unicode` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertsymbol?view=office-pia"/>
  public TextRange2 InsertSymbol(string FontName, int CharNumber, TriState Unicode) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.select?view=office-pia"/>
  public void Select() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Cut`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.cut?view=office-pia"/>
  public void Cut() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.copy?view=office-pia"/>
  public void Copy() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Paste`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.paste?view=office-pia"/>
  public TextRange2 Paste() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `PasteSpecial`.
  /// </summary>
  /// <param name="Format">The `Format` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.pastespecial?view=office-pia"/>
  public TextRange2 PasteSpecial(ClipboardFormat Format) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ChangeCase`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.changecase?view=office-pia"/>
  public void ChangeCase(TextChangeCase Type) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `AddPeriods`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.addperiods?view=office-pia"/>
  public void AddPeriods() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `RemovePeriods`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.removeperiods?view=office-pia"/>
  public void RemovePeriods() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Find`.
  /// </summary>
  /// <param name="FindWhat">The `FindWhat` parameter.</param>
  /// <param name="After">The `After` parameter.</param>
  /// <param name="MatchCase">The `MatchCase` parameter.</param>
  /// <param name="WholeWords">The `WholeWords` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.find?view=office-pia"/>
  public TextRange2 Find
  (string FindWhat, int After, TriState MatchCase,
    TriState WholeWords)
  { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Replace`.
  /// </summary>
  /// <param name="FindWhat">The `FindWhat` parameter.</param>
  /// <param name="ReplaceWhat">The `ReplaceWhat` parameter.</param>
  /// <param name="After">The `After` parameter.</param>
  /// <param name="MatchCase">The `MatchCase` parameter.</param>
  /// <param name="WholeWords">The `WholeWords` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.replace?view=office-pia"/>
  public TextRange2 Replace
  (string FindWhat, string ReplaceWhat, int After, TriState MatchCase,
    TriState WholeWords)
  { throw new NotImplementedException(); }
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
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.rotatedbounds?view=office-pia"/>
  public void RotatedBounds
    (out float X1, out float Y1, out float X2, out float Y2, out float X3, out float Y3, out float x4, out float y4)
  { throw new NotImplementedException(); }  
  /// <summary>
  /// Invokes `RtlRun`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.rtlrun?view=office-pia"/>
  public void RtlRun() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `LtrRun`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.ltrrun?view=office-pia"/>
  public void LtrRun() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `InsertChartField`.
  /// </summary>
  /// <param name="ChartFieldType">The `ChartFieldType` parameter.</param>
  /// <param name="Formula">The `Formula` parameter.</param>
  /// <param name="Position">The `Position` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertchartfield?view=office-pia"/>
  public TextRange2 InsertChartField(ChartFieldType ChartFieldType, string Formula, int Position) { throw new NotImplementedException(); }

  #endregion methods
}

