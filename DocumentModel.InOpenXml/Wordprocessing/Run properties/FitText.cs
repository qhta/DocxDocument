namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the fit text effect for a text run, enabling the text to be compressed or expanded to fit a specified width.
/// This interface provides properties for identifying the fit text run and specifying the target width in twips, allowing advanced text layout control in WordprocessingML documents.
/// </summary>
public interface FitText
{
  /// <summary>
  /// Identifier for the fit text run, used to distinguish multiple fit text effects within the same document.
  /// </summary>
  public Int32? Id { get; set; }

  /// <summary>
  /// Target width for the fit text effect, specified in twips. The text is compressed or expanded to fit this width.
  /// </summary>
  public Twips? Value { get; set; }
}