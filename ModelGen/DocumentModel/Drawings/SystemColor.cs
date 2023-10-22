namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color bound to predefined operating system elements.
/// </summary>
public partial class SystemColor
{
  
  /// <summary>
  ///   Specifies the color value that was last computed by the generating application.
  /// </summary>
  public DM.HexBinary? LastColor { get; set; }
  
}
