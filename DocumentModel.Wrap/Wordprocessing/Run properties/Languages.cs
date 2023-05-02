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
  public string? Regular { get; set; }

  /// <summary>
  ///   Language for complex (bidirectional) scripts
  /// </summary>
  public string? ComplexScript { get; set; }

  /// <summary>
  ///   Language for east-asian scripts.
  /// </summary>
  public string? EastAsia { get; set; }

}