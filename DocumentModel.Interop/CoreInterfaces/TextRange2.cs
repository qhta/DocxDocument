using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface TextRange2: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  string Text { get; set; }
  int Count { get; }
  TextRange2 Item(object Index);
  new IEnumerator GetEnumerator();
  object Parent { get; }
  TextRange2 Paragraphs { get; }
  TextRange2 Sentences { get; }
  TextRange2 Words { get; }
  TextRange2 Characters { get; }
  TextRange2 Lines { get; }
  TextRange2 Runs { get; }
  ParagraphFormat2 ParagraphFormat { get; }
  Font2 Font { get; }
  int Length { get; }
  int Start { get; }
  float BoundLeft { get; }
  float BoundTop { get; }
  float BoundWidth { get; }
  float BoundHeight { get; }
  TextRange2 TrimText();
  TextRange2 InsertAfter(string NewText = "");
  TextRange2 InsertBefore(string NewText = "");
  TextRange2 InsertSymbol(string FontName, int CharNumber, MsoTriState Unicode = MsoTriState.msoFalse);
  void Select();
  void Cut();
  void Copy();
  void Delete();
  TextRange2 Paste();
  TextRange2 PasteSpecial(MsoClipboardFormat Format);
  void ChangeCase(MsoTextChangeCase Type);
  void AddPeriods();
  void RemovePeriods();

  TextRange2 Find
  (string FindWhat, int After = 0, MsoTriState MatchCase = MsoTriState.msoFalse,
    MsoTriState WholeWords = MsoTriState.msoFalse);

  TextRange2 Replace
  (string FindWhat, string ReplaceWhat, int After = 0, MsoTriState MatchCase = MsoTriState.msoFalse,
    MsoTriState WholeWords = MsoTriState.msoFalse);

  void RotatedBounds
    (out float X1, out float Y1, out float X2, out float Y2, out float X3, out float Y3, out float x4, out float y4);

  MsoLanguageID LanguageID { get; set; }
  void RtlRun();
  void LtrRun();
  TextRange2 MathZones { get; }
  TextRange2 InsertChartField(MsoChartFieldType ChartFieldType, string Formula = "", int Position = -1);
}