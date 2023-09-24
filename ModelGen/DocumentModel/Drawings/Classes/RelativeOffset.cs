namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a relative offset effect. Sets up a new origin by offsetting relative to the size of the previous effect.
/// </summary>
public partial class RelativeOffset
{
  
  /// <summary>
  ///   Specifies the X offset.
  /// </summary>
  public Int32? OffsetX { get; set; }
  
  
  /// <summary>
  ///   Specifies the Y offset.
  /// </summary>
  public Int32? OffsetY { get; set; }
  
}
