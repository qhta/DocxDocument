namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a color bound to predefined operating system elements.
/// </summary>
public partial class SystemColor
{
  
  /// <summary>
  ///   Specifies the system color value.
  /// </summary>
  [SchemaAttr("val")]
  public DocumentModel.Drawings.SystemColorValues? Val { get; set; }
  
  
  /// <summary>
  ///   Specifies the color value that was last computed by the generating application.
  /// </summary>
  [SchemaAttr("lastClr")]
  public DocumentModel.HexBinaryValue? LastColor { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
