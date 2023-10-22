namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the 3D properties associated with a particular shape in DrawingML.  The 3D properties which can be applied to a shape are top and bottom bevels, a contour and an extrusion.
/// </summary>
public partial class Shape3DType
{
  
  /// <summary>
  ///   Defines the z coordinate for the 3D shape.
  /// </summary>
  public Int64? Z { get; set; }
  
  
  /// <summary>
  ///   Extrusion Height
  /// </summary>
  public Int64? ExtrusionHeight { get; set; }
  
  
  /// <summary>
  ///   Defines the width of the contour on the shape.
  /// </summary>
  public Int64? ContourWidth { get; set; }
  
  
  /// <summary>
  ///   Top Bevel.
  /// </summary>
  public DocumentModel.Drawings.BevelTop? BevelTop { get; set; }
  
  
  /// <summary>
  ///   Bottom Bevel.
  /// </summary>
  public DocumentModel.Drawings.BevelBottom? BevelBottom { get; set; }
  
  
  /// <summary>
  ///   Extrusion Color.
  /// </summary>
  public DocumentModel.Drawings.ExtrusionColor? ExtrusionColor { get; set; }
  
  
  /// <summary>
  ///   Contour Color.
  /// </summary>
  public DocumentModel.Drawings.ContourColor? ContourColor { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
