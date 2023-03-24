namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StyleSet Class.
/// </summary>
public class StyleSet: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? Id { get; set; }

  /// <summary>
  ///   val, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffKind? Val { get; set; }
}