namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LightRig Class.
/// </summary>
public interface ILightRig // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// rig, this property is only available in Office 2010 and later.
  /// </summary>
  public LightRigKind? LightRigType { get ; set; }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public LightRigDirectionKind? LightDirectionType { get ; set; }
  
  /// <summary>
  /// SphereCoordinates.
  /// </summary>
  public ISphereCoordinates? SphereCoordinates { get ; set; }
  
}
