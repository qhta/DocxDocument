namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that an embedded object is located at this position in the run’s contents. The layout properties of this embedded object, as well as an optional static representation, are specified using the drawing element.
/// </summary>
public partial class EmbeddedObject
{
  
  /// <summary>
  ///   dxaOrig
  /// </summary>
  public String? DxaOriginal { get; set; }
  
  
  /// <summary>
  ///   dyaOrig
  /// </summary>
  public String? DyaOriginal { get; set; }
  
  
  /// <summary>
  ///   anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public HexInt? AnchorId { get; set; }
  
  public Drawing? Drawing { get; set; }
  
  public Control? Control { get; set; }
  
  public ObjectEmbed? ObjectEmbed { get; set; }
  
  public ObjectLink? ObjectLink { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
