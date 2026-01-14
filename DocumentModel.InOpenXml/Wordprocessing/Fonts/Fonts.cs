namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents the root element of the font table in a WordprocessingML document.
  /// This interface provides access to and management of <see cref="FontProperties"/> objects, enabling advanced organization, referencing, and configuration of fonts used throughout the document.
  /// </summary>
  public interface Fonts: IElementCollection<FontProperties>
  {
    
  }