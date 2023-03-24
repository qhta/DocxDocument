namespace DocumentModel.Drawings.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WebVideoProperty Class.
/// </summary>
public class WebVideoProperty: ModelElement
{
  /// <summary>
  ///   embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  public String? EmbeddedHtml { get; set; }

  /// <summary>
  ///   h, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Height { get; set; }

  /// <summary>
  ///   w, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Width { get; set; }
}