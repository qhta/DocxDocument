namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ShapePropertiesExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IHiddenEffectsProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IHiddenFillProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IHiddenLineProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IHiddenScene3D))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IHiddenShape3D))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IShadowObscured))]
public class ShapePropertiesExtension: IShapePropertiesExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
