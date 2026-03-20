using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface TextRange2
{
  public TextRange2 Item(object Index);
  public TextRange2 TrimText();
  public TextRange2 InsertAfter(string NewText);
  public TextRange2 InsertBefore(string NewText);
  public TextRange2 InsertSymbol(string FontName, int CharNumber, MsoTriState Unicode);
  public void Select();
  public void Cut();
  public void Copy();
  public void Delete();
  public TextRange2 Paste();
  public TextRange2 PasteSpecial(MsoClipboardFormat Format);
  public void ChangeCase(MsoTextChangeCase Type);
  public void AddPeriods();
  public void RemovePeriods();
  public TextRange2 Find
  (string FindWhat, int After, MsoTriState MatchCase,
    MsoTriState WholeWords);
  public TextRange2 Replace
  (string FindWhat, string ReplaceWhat, int After, MsoTriState MatchCase,
    MsoTriState WholeWords);
  public void RotatedBounds
    (out float X1, out float Y1, out float X2, out float Y2, out float X3, out float Y3, out float x4, out float y4);
  public void RtlRun();
  public void LtrRun();
  public TextRange2 InsertChartField(MsoChartFieldType ChartFieldType, string Formula, int Position);
}
