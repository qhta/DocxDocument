namespace DocumentModel.Drawings;


/// <summary>
///   This element is nearly identical to the representation of 2-D transforms for ordinary shapes (§20.1.7.6). The only addition is a member to represent the Child offset and the Child extents.
/// </summary>
public partial class TransformGroup
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
  public DMD.Offset? Offset { get; set; }
  
  
  /// <summary>
  ///   Extents.
  /// </summary>
  public DMD.Extents? Extents { get; set; }
  
  
  /// <summary>
  ///   Child Offset.
  /// </summary>
  public DMD.ChildOffset? ChildOffset { get; set; }
  
  
  /// <summary>
  ///   Child Extents.
  /// </summary>
  public DMD.ChildExtents? ChildExtents { get; set; }
  
}
