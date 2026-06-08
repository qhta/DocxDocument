namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines languages for three script types: Normal, EastAsia, and Bidi.
/// </summary>
//[TypeConverter(typeof(LanguagesTypeConverter))]
public class ILanguages: ModelElement
{
  /// <summary>
  ///   ILanguage for all regular scripts.
  /// </summary>
  public string? Regular { get; set; }

  /// <summary>
  ///   ILanguage for complex (bidirectional) scripts
  /// </summary>
  public string? ComplexScript { get; set; }

  /// <summary>
  ///   ILanguage for east-asian scripts.
  /// </summary>
  public string? EastAsia { get; set; }

}
