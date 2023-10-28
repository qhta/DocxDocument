namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies all locking properties for a connection shape. These properties inform the generating application about specific properties that have been previously locked and thus should not be changed.
/// </summary>
public partial class GroupShapeLocks
{
  
  /// <summary>
  ///   Specifies that the corresponding group shape cannot be grouped. That is it cannot be combined within other shapes to form a group of shapes. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoGrouping { get; set; }
  
  
  /// <summary>
  ///   Specifies that the generating application should not show adjust handles for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoUngrouping { get; set; }
  
  
  /// <summary>
  ///   Specifies that the corresponding group shape cannot have any part of it be selected. That means that no picture, shapes or attached text can be selected either if this attribute has been specified. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoSelection { get; set; }
  
  
  /// <summary>
  ///   Specifies that the corresponding group shape cannot be rotated Objects that reside within the group can still be rotated unless they also have been locked. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoRotation { get; set; }
  
  
  /// <summary>
  ///   Disallow Aspect Ratio Change
  /// </summary>
  public Boolean? NoChangeAspect { get; set; }
  
  
  /// <summary>
  ///   Specifies that the corresponding graphic frame cannot be moved. Objects that reside within the graphic frame can still be moved unless they also have been locked. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoMove { get; set; }
  
  
  /// <summary>
  ///   Specifies that the corresponding group shape cannot be resized. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoResize { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
