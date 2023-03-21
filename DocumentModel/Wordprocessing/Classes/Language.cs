namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines languages for three script types: Normal, EastAsia, and Bidi.
/// </summary>
//[TypeConverter(typeof(LanguageConverter))]
public class Language: ModelElement
{
  /// <summary>
  ///   Language for all european scripts.
  /// </summary>
  public String? Normal { get; set; }

  /// <summary>
  ///   Language for east-asian scripts.
  /// </summary>
  public String? EastAsia { get; set; }

  /// <summary>
  ///   Language for complex (bidirectional) scripts
  /// </summary>
  public String? Bidi { get; set; }
}