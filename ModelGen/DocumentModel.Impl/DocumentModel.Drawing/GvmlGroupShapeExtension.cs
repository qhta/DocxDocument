namespace DocumentModel.Drawing;

/// <summary>
/// Defines the GvmlGroupShapeExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.IIsCanvas))]
public class GvmlGroupShapeExtension: IGvmlGroupShapeExtension
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
