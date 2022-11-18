namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Shape Resize Style.
/// </summary>
public interface IResizeHandles // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Shape Resize Style Type
  /// </summary>
  public ResizeHandlesString? Val { get ; set; }
  
}
