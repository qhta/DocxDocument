namespace DocumentModel.Office2021.Drawing.SketchyShapes;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ICustomGeometry))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.SketchyShapes.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IPresetGeometry))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.SketchyShapes.ILineSketchTypeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2021.Drawing.SketchyShapes.ILineSketchSeed))]
public class LineSketchStyleProperties: ILineSketchStyleProperties
{
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  public uint? Sd
  {
    get;
    set;
  }
  
}
