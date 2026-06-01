namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Custom Set of ICharacters Which Cannot End a ILine.
/// </summary>
public class NoLineBreaksAfterKinsoku: ModelElement
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
