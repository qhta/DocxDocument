namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color bound to predefined operating system elements.
/// </summary>
public partial class SystemColor
{
  
  /// <summary>
  ///   Specifies the system color value.
  /// </summary>
  public SystemColorKind? Val { get; set; }
  
  
  /// <summary>
  ///   Specifies the color value that was last computed by the generating application.
  /// </summary>
  public HexBinary? LastColor { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
