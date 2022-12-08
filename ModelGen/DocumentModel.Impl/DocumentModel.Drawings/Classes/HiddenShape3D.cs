namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HiddenShape3D Class.
/// </summary>
public class HiddenShape3DImpl: ModelElementImpl, HiddenShape3D
{
  public DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Shape Depth
  /// </summary>
  public Int64? Z
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  public Int64? ExtrusionHeight
  {
    get;
    set;
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  public Int64? ContourWidth
  {
    get;
    set;
  }
  
  /// <summary>
  /// Preset Material Type
  /// </summary>
  public PresetMaterialKind? PresetMaterial
  {
    get => (PresetMaterialKind?)OpenXmlElement?.PresetMaterial?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresetMaterial = (DocumentFormat.OpenXml.Drawing.PresetMaterialTypeValues?)value;
    }
  }
  
  /// <summary>
  /// Top Bevel.
  /// </summary>
  public BevelType? BevelTop
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  public BevelType? BevelBottom
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  public ExtrusionColor? ExtrusionColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  public ContourColor? ContourColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
