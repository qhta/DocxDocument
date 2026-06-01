namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines languages Ifor three script types: Normal, EastAsia, and Bidi.
/// </summary>
//[TypeConverter(typeof(LanguagesTypeConverter))]
public class ILanguages: ModelElement
{
  /// <summary>
  ///   ILanguage Ifor all regular scripts.
  /// </summary>
  public string? Regular { get; set; }

  /// <summary>
  ///   ILanguage Ifor complex (bidirectional) scripts
  /// </summary>
  public string? ComplexScript { get; set; }

  /// <summary>
  ///   ILanguage Ifor east-asian scripts.
  /// </summary>
  public string? EastAsia { get; set; }

}
