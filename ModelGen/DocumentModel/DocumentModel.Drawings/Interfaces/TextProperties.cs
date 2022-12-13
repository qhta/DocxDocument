namespace DocumentModel.Drawings;

/// <summary>
/// Text Properties.
/// </summary>
public interface TextProperties
{
  /// <summary>
  /// Apply 3D shape properties.
  /// </summary>
  public DocumentModel.Drawings.Shape3DType? Shape3DType { get ; set; }
  
  /// <summary>
  /// No text in 3D scene.
  /// </summary>
  public DocumentModel.Drawings.FlatText? FlatText { get ; set; }
  
}
