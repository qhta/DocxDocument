namespace DocumentModel.Wordprocessing;


/// <summary>
///   Magnification Setting.
/// </summary>
public partial class Zoom
{
  
  /// <summary>
  ///   Zoom Type
  /// </summary>
  [SchemaAttr("w:val")]
  public DocumentModel.Wordprocessing.PresetZoomValues? Val { get; set; }
  
  
  /// <summary>
  ///   Zoom Percentage
  /// </summary>
  [SchemaAttr("w:percent")]
  public String? Percent { get; set; }
  
}
