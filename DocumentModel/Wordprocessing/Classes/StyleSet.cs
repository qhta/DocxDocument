namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the StyleSet Class.
/// </summary>
public class StyleSet
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