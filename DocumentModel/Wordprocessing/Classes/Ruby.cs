namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Phonetic Guide.
/// </summary>
public class Ruby: ModelElement, IRunContent
{
  /// <summary>
  ///   Phonetic Guide Properties.
  /// </summary>
  public RubyProperties? RubyProperties { get; set; }

  /// <summary>
  ///   Phonetic Guide Text.
  /// </summary>
  public RubyContent? RubyContent { get; set; }

  /// <summary>
  ///   Phonetic Guide Base Text.
  /// </summary>
  public RubyBase? RubyBase { get; set; }
}