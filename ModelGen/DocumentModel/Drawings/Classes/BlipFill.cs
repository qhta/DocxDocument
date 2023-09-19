namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the type of picture fill that the picture object has. Because a picture has a picture fill already by default, it is possible to have two fills specified for a picture object. An example of this is shown below.
/// </summary>
public partial class BlipFill
{
  
  /// <summary>
  ///   Specifies the DPI (dots per inch) used to calculate the size of the blip. If not present or zero, the DPI in the blip is used.
  /// </summary>
  [SchemaAttr("dpi")]
  public UInt32? Dpi { get; set; }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  [SchemaAttr("rotWithShape")]
  public Boolean? RotateWithShape { get; set; }
  
  
  /// <summary>
  ///   Blip.
  /// </summary>
  public DocumentModel.Drawings.Blip? Blip { get; set; }
  
  
  /// <summary>
  ///   Source Rectangle.
  /// </summary>
  public DocumentModel.Drawings.RelativeRectangleType? SourceRectangle { get; set; }
  
  public DocumentModel.Drawings.Tile? Tile { get; set; }
  
  public DocumentModel.Drawings.Stretch? Stretch { get; set; }
  
}
