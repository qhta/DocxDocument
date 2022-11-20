namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Text Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IFlatText))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IShape3DType))]
public class TextProperties: ITextProperties
{
  /// <summary>
  /// Apply 3D shape properties.
  /// </summary>
  public IShape3DType? Shape3DType
  {
    get;
    set;
  }
  
  /// <summary>
  /// No text in 3D scene.
  /// </summary>
  public IFlatText? FlatText
  {
    get;
    set;
  }
  
}
