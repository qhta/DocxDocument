namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents the ruby counterpart of the <see cref="SimpleField"/> interface in a WordprocessingML document.
  /// This interface extends <see cref="SimpleField"/> and <see cref="RubyContent"/>, enabling advanced integration of simple fields within ruby text, supporting East Asian typography and annotation scenarios where fields are embedded in phonetic guides or ruby runs.
  /// </summary>
  public interface SimpleFieldRuby : SimpleField, RubyContent
  {
  }