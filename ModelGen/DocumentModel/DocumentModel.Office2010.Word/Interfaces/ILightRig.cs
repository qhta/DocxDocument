namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the LightRig Class.
/// </summary>
public interface ILightRig // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// rig, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.LightRigKind? LightRigType { get ; set; }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Office2010.Word.LightRigDirectionKind? LightDirectionType { get ; set; }
  
  /// <summary>
  /// SphereCoordinates.
  /// </summary>
  public DocumentModel.Office2010.Word.ISphereCoordinates? SphereCoordinates { get ; set; }
  
}
