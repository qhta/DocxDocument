namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the type of picture fill that the picture object has. Because a picture has a picture fill already by default, it is possible to have two fills specified for a picture object. An example of this is shown below.
/// </summary>
public partial class BlipFill
{
  
  /// <summary>
  ///   Specifies the DPI (dots per inch) used to calculate the size of the blip. If not present or zero, the DPI in the blip is used.
  /// </summary>
  public UInt32? Dpi { get; set; }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape { get; set; }
  
  
  /// <summary>
  ///   Blip.
  /// </summary>
  public DMD.Blip? Blip { get; set; }
  
  
  /// <summary>
  ///   Source Rectangle.
  /// </summary>
  public DMD.SourceRectangle? SourceRectangle { get; set; }
  
  public DMD.Tile? Tile { get; set; }
  
  public DMD.Stretch? Stretch { get; set; }
  
}
