using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextRange2` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2?view=office-pia"/>
public partial interface TextRange2
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.item?view=office-pia"/>
  public TextRange2 Item(object Index);
  /// <summary>
  /// Invokes `TrimText`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.trimtext?view=office-pia"/>
  public TextRange2 TrimText();
  /// <summary>
  /// Invokes `InsertAfter`.
  /// </summary>
  /// <param name="NewText">The `NewText` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertafter?view=office-pia"/>
  public TextRange2 InsertAfter(string NewText);
  /// <summary>
  /// Invokes `InsertBefore`.
  /// </summary>
  /// <param name="NewText">The `NewText` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertbefore?view=office-pia"/>
  public TextRange2 InsertBefore(string NewText);
  /// <summary>
  /// Invokes `InsertSymbol`.
  /// </summary>
  /// <param name="Name">The `Name` parameter.</param>
  /// <param name="CharNumber">The `CharNumber` parameter.</param>
  /// <param name="Unicode">The `Unicode` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertsymbol?view=office-pia"/>
  public TextRange2 InsertSymbol(string FontName, int CharNumber, TriState Unicode);
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
  public TextRange2 Paste();
  /// <summary>
  /// Invokes `PasteSpecial`.
  /// </summary>
  /// <param name="Format">The `Format` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.pastespecial?view=office-pia"/>
  public TextRange2 PasteSpecial(ClipboardFormat Format);
  /// <summary>
  /// Invokes `ChangeCase`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.changecase?view=office-pia"/>
  public void ChangeCase(TextChangeCase Type);
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
  public TextRange2 Find
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
  public TextRange2 Replace
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
  /// <param name="ChartFieldType">The `ChartFieldType` parameter.</param>
  /// <param name="Formula">The `Formula` parameter.</param>
  /// <param name="Position">The `Position` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertchartfield?view=office-pia"/>
  public TextRange2 InsertChartField(ChartFieldType ChartFieldType, string Formula, int Position);
}

