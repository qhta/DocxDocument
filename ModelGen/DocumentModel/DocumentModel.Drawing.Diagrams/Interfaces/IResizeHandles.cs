namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Shape Resize Style.
/// </summary>
public interface IResizeHandles // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Shape Resize Style Type
  /// </summary>
  public ResizeHandlesStringValues? Val { get ; set; }
  
}
