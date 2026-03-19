namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the replace criteria for a find-and-replace operation.
/// </summary>
public partial interface Replacement : InteropObject
{
  /// <summary>
  /// The font.
  /// </summary>
  public Font Font { get; set; }

  /// <summary>
  /// The paragraph format.
  /// </summary>
  public ParagraphFormat ParagraphFormat { get; set; }

  /// <summary>
  /// The style.
  /// </summary>
  public object Style { get; set; }

  /// <summary>
  /// The text.
  /// </summary>
  public string Text { get; set; }

  /// <summary>
  /// The language id.
  /// </summary>
  public WdLanguageID LanguageID { get; set; }

  /// <summary>
  /// The highlight.
  /// </summary>
  public int Highlight { get; set; }

  /// <summary>
  /// The frame.
  /// </summary>
  public Frame Frame { get; }

  /// <summary>
  /// The language idfar east.
  /// </summary>
  public WdLanguageID LanguageIDFarEast { get; set; }

  /// <summary>
  /// The no proofing.
  /// </summary>
  public int NoProofing { get; set; }
}
