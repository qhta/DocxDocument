namespace DocumentModel.Drawing;

/// <summary>
/// Defines the PtExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Drawing.Diagram.INonVisualDrawingProperties))]
public class PtExtension: IPtExtension
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
