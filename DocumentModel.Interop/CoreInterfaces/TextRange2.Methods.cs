using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextRange2` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2?view=office-pia` for Office interop details.
/// </remarks>
public partial interface TextRange2
{
  /// <summary>
  /// Invokes `Item`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.item?view=office-pia
  /// </remarks>
  public TextRange2 Item(object Index);
  /// <summary>
  /// Invokes `TrimText`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.trimtext?view=office-pia
  /// </remarks>
  public TextRange2 TrimText();
  /// <summary>
  /// Invokes `InsertAfter`.
  /// </summary>
  /// <param name="NewText">The `NewText` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertafter?view=office-pia
  /// </remarks>
  public TextRange2 InsertAfter(string NewText);
  /// <summary>
  /// Invokes `InsertBefore`.
  /// </summary>
  /// <param name="NewText">The `NewText` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertbefore?view=office-pia
  /// </remarks>
  public TextRange2 InsertBefore(string NewText);
  /// <summary>
  /// Invokes `InsertSymbol`.
  /// </summary>
  /// <param name="FontName">The `FontName` parameter.</param>
  /// <param name="CharNumber">The `CharNumber` parameter.</param>
  /// <param name="Unicode">The `Unicode` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertsymbol?view=office-pia
  /// </remarks>
  public TextRange2 InsertSymbol(string FontName, int CharNumber, MsoTriState Unicode);
  /// <summary>
  /// Invokes `Select`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.select?view=office-pia
  /// </remarks>
  public void Select();
  /// <summary>
  /// Invokes `Cut`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.cut?view=office-pia
  /// </remarks>
  public void Cut();
  /// <summary>
  /// Invokes `Copy`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.copy?view=office-pia
  /// </remarks>
  public void Copy();
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.delete?view=office-pia
  /// </remarks>
  public void Delete();
  /// <summary>
  /// Invokes `Paste`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.paste?view=office-pia
  /// </remarks>
  public TextRange2 Paste();
  /// <summary>
  /// Invokes `PasteSpecial`.
  /// </summary>
  /// <param name="Format">The `Format` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.pastespecial?view=office-pia
  /// </remarks>
  public TextRange2 PasteSpecial(MsoClipboardFormat Format);
  /// <summary>
  /// Invokes `ChangeCase`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.changecase?view=office-pia
  /// </remarks>
  public void ChangeCase(MsoTextChangeCase Type);
  /// <summary>
  /// Invokes `AddPeriods`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.addperiods?view=office-pia
  /// </remarks>
  public void AddPeriods();
  /// <summary>
  /// Invokes `RemovePeriods`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.removeperiods?view=office-pia
  /// </remarks>
  public void RemovePeriods();
  /// <summary>
  /// Invokes `Find`.
  /// </summary>
  /// <param name="FindWhat">The `FindWhat` parameter.</param>
  /// <param name="After">The `After` parameter.</param>
  /// <param name="MatchCase">The `MatchCase` parameter.</param>
  /// <param name="WholeWords">The `WholeWords` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.find?view=office-pia
  /// </remarks>
  public TextRange2 Find
  (string FindWhat, int After, MsoTriState MatchCase,
    MsoTriState WholeWords);
  /// <summary>
  /// Invokes `Replace`.
  /// </summary>
  /// <param name="FindWhat">The `FindWhat` parameter.</param>
  /// <param name="ReplaceWhat">The `ReplaceWhat` parameter.</param>
  /// <param name="After">The `After` parameter.</param>
  /// <param name="MatchCase">The `MatchCase` parameter.</param>
  /// <param name="WholeWords">The `WholeWords` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.replace?view=office-pia
  /// </remarks>
  public TextRange2 Replace
  (string FindWhat, string ReplaceWhat, int After, MsoTriState MatchCase,
    MsoTriState WholeWords);
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
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.rotatedbounds?view=office-pia
  /// </remarks>
  public void RotatedBounds
    (out float X1, out float Y1, out float X2, out float Y2, out float X3, out float Y3, out float x4, out float y4);
  /// <summary>
  /// Invokes `RtlRun`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.rtlrun?view=office-pia
  /// </remarks>
  public void RtlRun();
  /// <summary>
  /// Invokes `LtrRun`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.ltrrun?view=office-pia
  /// </remarks>
  public void LtrRun();
  /// <summary>
  /// Invokes `InsertChartField`.
  /// </summary>
  /// <param name="ChartFieldType">The `ChartFieldType` parameter.</param>
  /// <param name="Formula">The `Formula` parameter.</param>
  /// <param name="Position">The `Position` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textrange2.insertchartfield?view=office-pia
  /// </remarks>
  public TextRange2 InsertChartField(MsoChartFieldType ChartFieldType, string Formula, int Position);
}
