namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents paragraph properties for a specific numbering level, used in <see cref="NumLevel"/> definitions in a WordprocessingML document.
  /// This interface extends <see cref="ExtBaseParagraphProperties"/> and is used to specify formatting, layout, and other paragraph-level settings that apply to paragraphs at a particular numbering level, enabling advanced list and outline formatting.
  /// </summary>
  public interface NumberingLevelParagraphProperties : ExtBaseParagraphProperties
  {
  }