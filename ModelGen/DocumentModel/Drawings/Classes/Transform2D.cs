namespace DocumentModel.Drawings;


/// <summary>
///   This element is nearly identical to the representation of 2-D transforms for ordinary shapes (§20.1.7.6). The only addition is a member to represent the Child offset and the Child extents.
/// </summary>
public partial class Transform2D
{
  
  /// <summary>
  ///   Rotation. Specifies the clockwise rotation of a group in 1/64000 of a degree.
  /// </summary>
  public Int32? Rotation { get; set; }
  
  
  /// <summary>
  ///   Horizontal flip. When true, this attribute defines that the group is flipped horizontally about the center of its bounding box.
  /// </summary>
  public Boolean? HorizontalFlip { get; set; }
  
  
  /// <summary>
  ///   Vertical flip. When true, this attribute defines that the group is flipped vertically about the center of its bounding box.
  /// </summary>
  public Boolean? VerticalFlip { get; set; }
  
  
  /// <summary>
  ///   Offset.
  /// </summary>
  public DocumentModel.Drawings.Offset? Offset { get; set; }
  
  
  /// <summary>
  ///   Extents.
  /// </summary>
  public DocumentModel.Drawings.Extents? Extents { get; set; }
  
}
