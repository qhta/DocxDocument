namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents the default paragraph properties for text formatting in a WordprocessingML document.
  /// This interface extends <see cref="IBaseParagraphProperties"/> and is used in <see cref="DocDefaults"/> to specify the default paragraph-level formatting applied to all paragraphs in the document unless overridden by more specific formatting.
  /// </summary>
  public interface DefaultParagraphProperties : IBaseParagraphProperties
  {
  }