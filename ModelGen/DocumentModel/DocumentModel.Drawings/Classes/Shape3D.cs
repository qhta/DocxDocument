namespace DocumentModel.Drawings;

/// <summary>
/// 3-D Shape Properties.
/// </summary>
public class Shape3D
{
  /// <summary>
  /// Preset Material Type
  /// </summary>
  public PresetMaterialKind? PresetMaterial
  {
    get;
    set;
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
