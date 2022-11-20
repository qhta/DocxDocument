namespace DocumentModel.Drawing;

/// <summary>
/// Text Shape.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IUseShapeRectangle))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITextBody))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ITransform2D))]
public class TextShape: ITextShape
{
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public DocumentModel.Drawing.ITextBody? TextBody
  {
    get;
    set;
  }
  
}
