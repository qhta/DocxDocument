namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies all locking properties for a graphic frame. These properties inform the generating application about specific properties that have been previously locked and thus should not be changed.
/// </summary>
public partial class PictureLocks
{
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape grouping for the corresponding connection shape. That is it cannot be combined within other shapes to form a group of shapes. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoGrouping { get; set; }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow selecting of the corresponding connection shape. That means also that no picture, shapes or text attached to this connection shape can be selected if this attribute has been specified. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoSelection { get; set; }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape rotation changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoRotation { get; set; }
  
  
  /// <summary>
  ///   Disallow Aspect Ratio Change
  /// </summary>
  public Boolean? NoChangeAspect { get; set; }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow position changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoMove { get; set; }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow size changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoResize { get; set; }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape point changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoEditPoints { get; set; }
  
  
  /// <summary>
  ///   Specifies that the generating application should not show adjust handles for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoAdjustHandles { get; set; }
  
  
  /// <summary>
  ///   Disallow Arrowhead Changes
  /// </summary>
  public Boolean? NoChangeArrowheads { get; set; }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape type changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoChangeShapeType { get; set; }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow cropping for the corresponding picture. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoCrop { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
