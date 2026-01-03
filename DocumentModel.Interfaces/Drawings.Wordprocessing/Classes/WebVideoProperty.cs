namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
///   Defines the WebVideoProperty Class.
/// </summary>
public interface WebVideoProperty: IModelElement
{
  /// <summary>
  ///   embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  public string? EmbeddedHtml { get; set; }
  /// <summary>
  ///   h, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Height { get; set; }
  /// <summary>
  ///   w, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Width { get; set; }
}