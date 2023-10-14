namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color bound to predefined operating system elements.
/// </summary>
public partial class SystemColor
{
  
  /// <summary>
  ///   Specifies the system color value.
  /// </summary>
  public DocumentModel.Drawings.SystemColorKind? Val { get; set; }
  
  
  /// <summary>
  ///   Specifies the color value that was last computed by the generating application.
  /// </summary>
  public DM.HexBinary? LastColor { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
