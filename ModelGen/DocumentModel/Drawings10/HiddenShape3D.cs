namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the HiddenShape3D Class.
/// </summary>
public partial class HiddenShape3D
{
  
  /// <summary>
  ///   Shape Depth
  /// </summary>
  public Int64? Z { get; set; }
  
  
  /// <summary>
  ///   Extrusion Height
  /// </summary>
  public Int64? ExtrusionHeight { get; set; }
  
  
  /// <summary>
  ///   Contour Width
  /// </summary>
  public Int64? ContourWidth { get; set; }
  
  
  /// <summary>
  ///   Top Bevel.
  /// </summary>
  public DMD.BevelTop? BevelTop { get; set; }
  
  
  /// <summary>
  ///   Bottom Bevel.
  /// </summary>
  public DMD.BevelBottom? BevelBottom { get; set; }
  
  
  /// <summary>
  ///   Extrusion Color.
  /// </summary>
  public DMD.ExtrusionColor? ExtrusionColor { get; set; }
  
  
  /// <summary>
  ///   Contour Color.
  /// </summary>
  public DMD.ContourColor? ContourColor { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
