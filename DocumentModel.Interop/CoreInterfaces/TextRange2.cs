using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface TextRange2: InteropDictionary<string, TextRange2>
{
  public string Text { get; set; }
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
  public MsoLanguageID LanguageID { get; set; }
  public TextRange2 MathZones { get; }
}
