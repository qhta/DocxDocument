namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies all locking properties for a graphic frame. These properties inform the generating application about specific properties that have been previously locked and thus should not be changed.
/// </summary>
public partial class GraphicFrameLocks
{
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape grouping for the corresponding graphic frame. That is it cannot be combined within other shapes to form a group of shapes. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoGrouping { get; set; }
  
  
  /// <summary>
  ///   Disallow Selection of Child Shapes
  /// </summary>
  public Boolean? NoDrilldown { get; set; }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow selecting of the corresponding picture. That means also that no picture, shapes or text attached to this picture can be selected if this attribute has been specified. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoSelection { get; set; }
  
  
  /// <summary>
  ///   Disallow Aspect Ratio Change
  /// </summary>
  public Boolean? NoChangeAspect { get; set; }
  
  
  /// <summary>
  ///   Specifies that the corresponding graphic frame cannot be moved. Objects that reside within the graphic frame can still be moved unless they also have been locked. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoMove { get; set; }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow size changes for the corresponding graphic frame. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  public Boolean? NoResize { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
