namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines languages for three script types: Normal, EastAsia, and Bidi.
/// </summary>
public interface ILanguages: IModelElement
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