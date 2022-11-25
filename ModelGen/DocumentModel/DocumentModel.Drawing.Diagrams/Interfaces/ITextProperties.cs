namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Text Properties.
/// </summary>
public interface ITextProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Apply 3D shape properties.
  /// </summary>
  public DocumentModel.Drawing.IShape3DType? Shape3DType { get ; set; }
  
  /// <summary>
  /// No text in 3D scene.
  /// </summary>
  public DocumentModel.Drawing.IFlatText? FlatText { get ; set; }
  
}
