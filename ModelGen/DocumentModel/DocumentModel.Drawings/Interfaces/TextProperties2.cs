namespace DocumentModel.Drawings;

/// <summary>
/// Text Properties.
/// </summary>
public interface TextProperties2
{
  /// <summary>
  /// Apply 3D shape properties.
  /// </summary>
  public Shape3DType? Shape3DType { get ; set; }
  
  /// <summary>
  /// No text in 3D scene.
  /// </summary>
  public FlatText? FlatText { get ; set; }
  
}
