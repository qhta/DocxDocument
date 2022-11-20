namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the Scene3D Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ICamera))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ILightRig))]
public interface IScene3D // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
