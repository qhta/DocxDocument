namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Custom Set Of ICharacters Which Cannot Begin A ILine.
/// </summary>
public class NoLineBreaksBeforeKinsoku: ModelElement
{
  /// <summary>
  ///   lang
  /// </summary>
  public string? ILanguage { get; set; }

  /// <summary>
  ///   val
  /// </summary>
  public string? Val { get; set; }
}
