namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Scene3D Class.
/// </summary>
public interface IScene3D // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Camera.
  /// </summary>
  public DocumentModel.Office2010.Word.ICamera? Camera { get ; set; }
  
  /// <summary>
  /// LightRig.
  /// </summary>
  public DocumentModel.Office2010.Word.ILightRig? LightRig { get ; set; }
  
}
