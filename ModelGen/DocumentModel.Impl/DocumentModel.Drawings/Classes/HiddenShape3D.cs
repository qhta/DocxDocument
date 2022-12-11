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
  
  public HiddenShape3DImpl(): base() {}
  
  public HiddenShape3DImpl(DocumentFormat.OpenXml.Office2010.Drawing.HiddenShape3D openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Shape Depth
  /// </summary>
  public Int64? Z
  {
    get => (Int64?)OpenXmlElement?.Z?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Z = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Extrusion Height
  /// </summary>
  public Int64? ExtrusionHeight
  {
    get => (Int64?)OpenXmlElement?.ExtrusionHeight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ExtrusionHeight = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Contour Width
  /// </summary>
  public Int64? ContourWidth
  {
    get => (Int64?)OpenXmlElement?.ContourWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ContourWidth = (System.Int64?)value;
    }
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Bottom Bevel.
  /// </summary>
  public BevelType? BevelBottom
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Extrusion Color.
  /// </summary>
  public ExtrusionColor? ExtrusionColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Contour Color.
  /// </summary>
  public ContourColor? ContourColor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
