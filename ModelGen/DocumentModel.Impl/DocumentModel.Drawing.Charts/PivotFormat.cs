namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Pivot Format.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDataLabel))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IMarker))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIndex))]
public class PivotFormat: IPivotFormat
{
  /// <summary>
  /// Index.
  /// </summary>
  public IIndex? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Drawing.Charts.IMarker? Marker
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Label.
  /// </summary>
  public DocumentModel.Drawing.Charts.IDataLabel? DataLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
