namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the GeoCache Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IClear))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.ChartDrawing.IXsdbase64Binary))]
public class GeoCache: IGeoCache
{
  /// <summary>
  /// provider, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Provider
  {
    get;
    set;
  }
  
}
