namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the 3D properties associated with a particular shape in DrawingML.  The 3D properties which can be applied to a shape are top and bottom bevels, a contour and an extrusion.
/// </summary>
public partial class Shape3DType
{
  
  /// <summary>
  ///   Defines the z coordinate for the 3D shape.
  /// </summary>
  [SchemaAttr("z")]
  public Int64? Z { get; set; }
  
  
  /// <summary>
  ///   Extrusion Height
  /// </summary>
  [SchemaAttr("extrusionH")]
  public Int64? ExtrusionHeight { get; set; }
  
  
  /// <summary>
  ///   Defines the width of the contour on the shape.
  /// </summary>
  [SchemaAttr("contourW")]
  public Int64? ContourWidth { get; set; }
  
  
  /// <summary>
  ///   Defines the preset material which is combined with the lighting properties to give the final look and feel of a shape.
  /// </summary>
  [SchemaAttr("prstMaterial")]
  public DocumentModel.Drawings.PresetMaterialTypeValues? PresetMaterial { get; set; }
  
  
  /// <summary>
  ///   Top Bevel.
  /// </summary>
  public DocumentModel.Drawings.BevelType? BevelTop { get; set; }
  
  
  /// <summary>
  ///   Bottom Bevel.
  /// </summary>
  public DocumentModel.Drawings.BevelType? BevelBottom { get; set; }
  
  
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
