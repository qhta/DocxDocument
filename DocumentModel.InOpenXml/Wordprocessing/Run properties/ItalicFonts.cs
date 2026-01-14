namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents italic formatting for run fonts, supporting both regular and complex script text.
  /// This interface extends <see cref="DualBool"/> and <see cref="RunProperty"/>, enabling specification of italic style for different script types in WordprocessingML documents.
  /// </summary>
  public interface ItalicFonts : DualBool, RunProperty
  {
  }
