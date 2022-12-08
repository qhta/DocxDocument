namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CategoryFilterException Class.
/// </summary>
public class CategoryFilterExceptionImpl: ModelElementImpl, CategoryFilterException
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterException?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public String? SequenceOfReferences
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties3? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Explosion.
  /// </summary>
  public UInt32? Explosion
  {
    get;
    set;
  }
  
  /// <summary>
  /// InvertIfNegativeBoolean.
  /// </summary>
  public Boolean? InvertIfNegativeBoolean
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bubble3D.
  /// </summary>
  public Boolean? Bubble3D
  {
    get;
    set;
  }
  
  /// <summary>
  /// Marker.
  /// </summary>
  public Marker2? Marker
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataLabel.
  /// </summary>
  public DataLabel2? DataLabel
  {
    get;
    set;
  }
  
}
