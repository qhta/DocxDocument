namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IInvertIfNegativeBoolean))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IBubble3D))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IDataLabel))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IMarker))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IExplosion))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ISequenceOfReferences))]
public class CategoryFilterException: ICategoryFilterException
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public ISequenceOfReferences? SequenceOfReferences
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IExplosion? Explosion
  {
    get;
    set;
  }
  
  /// <summary>
  /// InvertIfNegativeBoolean.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IInvertIfNegativeBoolean? InvertIfNegativeBoolean
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IBubble3D? Bubble3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IMarker? Marker
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IDataLabel? DataLabel
  {
    get;
    set;
  }
  
}
