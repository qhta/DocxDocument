namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines languages for three script types: Normal, EastAsia, and Bidi.
/// </summary>
//[TypeConverter(typeof(LanguagesTypeConverter))]
public class Languages: ModelElement
{
  /// <summary>
  ///   Language for all regular scripts.
  /// </summary>
  public String? Regular { get; set; }

  /// <summary>
  ///   Language for complex (bidirectional) scripts
  /// </summary>
  public String? ComplexScript { get; set; }

  /// <summary>
  ///   Language for east-asian scripts.
  /// </summary>
  public String? EastAsia { get; set; }

}