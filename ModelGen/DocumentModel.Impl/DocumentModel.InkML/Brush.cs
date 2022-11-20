namespace DocumentModel.InkML;

/// <summary>
/// Defines the Brush Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IAnnotation))]
[ChildElementInfo(typeof(DocumentModel.InkML.IAnnotationXml))]
[ChildElementInfo(typeof(DocumentModel.InkML.IBrushProperty))]
public class Brush: IBrush
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// brushRef
  /// </summary>
  public string? BrushRef
  {
    get;
    set;
  }
  
}
