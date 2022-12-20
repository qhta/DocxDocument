namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtension Class.
/// </summary>
public partial interface ShapePropertiesExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.HiddenFillProperties? HiddenFillProperties { get; set; }
  
  public DocumentModel.Drawings.HiddenLineProperties? HiddenLineProperties { get; set; }
  
  public DocumentModel.Drawings.HiddenEffectsProperties? HiddenEffectsProperties { get; set; }
  
  public DocumentModel.Drawings.HiddenScene3D? HiddenScene3D { get; set; }
  
  public DocumentModel.Drawings.HiddenShape3D? HiddenShape3D { get; set; }
  
  public Boolean? ShadowObscured { get; set; }
  
}
