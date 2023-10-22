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
  public DM.HexBinary? AnchorId { get; set; }
  
  public DocumentModel.Wordprocessing.Drawing? Drawing { get; set; }
  
  public DocumentModel.Wordprocessing.Control? Control { get; set; }
  
  public DocumentModel.Wordprocessing.ObjectEmbed? ObjectEmbed { get; set; }
  
  public DocumentModel.Wordprocessing.ObjectLink? ObjectLink { get; set; }
  
}
