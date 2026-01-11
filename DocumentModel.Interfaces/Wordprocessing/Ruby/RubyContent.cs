namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents the phonetic guide text (ruby text) in a WordprocessingML document.
  /// This interface is used for the text displayed above the base text in a ruby construct, providing pronunciation or annotation aids for East Asian scripts and other language learning scenarios.
  /// </summary>
  public interface RubyContent : CollectionItem
  {
  }