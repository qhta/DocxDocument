namespace DocumentModel.Office2016.Drawing.Charts;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Charts.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Charts.IInvertIfNegativeBoolean))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Charts.IBubble3DBoolean))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Charts.IDLbl))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Charts.IMarker))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Charts.IUnsignedIntegerType))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Charts.IUniqueIdChartUniqueID))]
public class CategoryFilterException: ICategoryFilterException
{
  /// <summary>
  /// UniqueIdChartUniqueID.
  /// </summary>
  public IUniqueIdChartUniqueID? UniqueIdChartUniqueID
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2016.Drawing.Charts.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// UnsignedIntegerType.
  /// </summary>
  public DocumentModel.Office2016.Drawing.Charts.IUnsignedIntegerType? UnsignedIntegerType
  {
    get;
    set;
  }
  
  /// <summary>
  /// InvertIfNegativeBoolean.
  /// </summary>
  public DocumentModel.Office2016.Drawing.Charts.IInvertIfNegativeBoolean? InvertIfNegativeBoolean
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bubble3DBoolean.
  /// </summary>
  public IBubble3DBoolean? Bubble3DBoolean
  {
    get;
    set;
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Office2016.Drawing.Charts.IMarker? Marker
  {
    get;
    set;
  }
  
  /// <summary>
  /// DLbl.
  /// </summary>
  public IDLbl? DLbl
  {
    get;
    set;
  }
  
}
