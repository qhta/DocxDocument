namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Defines the WebVideoProperty Class.
/// </summary>
public partial class WebVideoProperty
{
  
  /// <summary>
  ///   embeddedHtml, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("embeddedHtml")]
  public String? EmbeddedHtml { get; set; }
  
  
  /// <summary>
  ///   h, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("h")]
  public UInt32? Height { get; set; }
  
  
  /// <summary>
  ///   w, this property is only available in Office 2013 and later.
  /// </summary>
  [SchemaAttr("w")]
  public UInt32? Width { get; set; }
  
}
