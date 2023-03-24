namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FontCharSet Class.
/// </summary>
public class FontCharSet: ModelElement
{
  /// <summary>
  ///   val
  /// </summary>
  public String? Val { get; set; }

  /// <summary>
  ///   characterSet
  /// </summary>
  public StrictCharacterSet? StrictCharacterSet { get; set; }
}