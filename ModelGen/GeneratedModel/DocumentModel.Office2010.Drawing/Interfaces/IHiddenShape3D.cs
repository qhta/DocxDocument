namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the HiddenShape3D Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IBevelTop))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IBevelBottom))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtrusionColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IContourColor))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public interface IHiddenShape3D // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape Depth
  /// </summary>
  public long? Z { get ; set; }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  public long? ExtrusionHeight { get ; set; }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  public long? ContourWidth { get ; set; }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  public DocumentModel.Drawing.PresetMaterialType? PresetMaterial { get ; set; }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  public DocumentModel.Drawing.IBevelTop? BevelTop { get ; set; }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  public DocumentModel.Drawing.IBevelBottom? BevelBottom { get ; set; }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  public DocumentModel.Drawing.IExtrusionColor? ExtrusionColor { get ; set; }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  public DocumentModel.Drawing.IContourColor? ContourColor { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList { get ; set; }
  
}
