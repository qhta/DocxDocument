namespace DocumentModel.InkML;

/// <summary>
/// Defines the CanvasTransform Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.InkML.IMapping))]
public class CanvasTransform: ICanvasTransform
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
  /// invertible
  /// </summary>
  public bool? Invertible
  {
    get;
    set;
  }
  
}
