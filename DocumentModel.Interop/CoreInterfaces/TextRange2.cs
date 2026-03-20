using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface TextRange2: InteropDictionary<string, TextRange2>
{
  public string Text { get; set; }
  public TextRange2 Item(object Index);
  public TextRange2 Paragraphs { get; }
  public TextRange2 Sentences { get; }
  public TextRange2 Words { get; }
  public TextRange2 Characters { get; }
  public TextRange2 Lines { get; }
  public TextRange2 Runs { get; }
  public ParagraphFormat2 ParagraphFormat { get; }
  public Font2 Font { get; }
  public int Length { get; }
  public int Start { get; }
  public float BoundLeft { get; }
  public float BoundTop { get; }
  public float BoundWidth { get; }
  public float BoundHeight { get; }
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

  public MsoLanguageID LanguageID { get; set; }
  public void RtlRun();
  public void LtrRun();
  public TextRange2 MathZones { get; }
  public TextRange2 InsertChartField(MsoChartFieldType ChartFieldType, string Formula, int Position);
}
