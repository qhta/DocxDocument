namespace DocumentModel.Drawings;


/// <summary>
///   Defines the BackgroundRemoval Class.
/// </summary>
public partial class BackgroundRemoval
{
  
  /// <summary>
  ///   t, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("t")]
  public Int32? MarqueeTop { get; set; }
  
  
  /// <summary>
  ///   b, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("b")]
  public Int32? MarqueeBottom { get; set; }
  
  
  /// <summary>
  ///   l, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("l")]
  public Int32? MarqueeLeft { get; set; }
  
  
  /// <summary>
  ///   r, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("r")]
  public Int32? MarqueeRight { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
