namespace DocumentModel.Drawings;

/// <summary>
/// Soft Edge Effect.
/// </summary>
public partial class SoftEdgeImpl: ModelElementImpl, SoftEdge
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.SoftEdge? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.SoftEdge?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public SoftEdgeImpl(): base() {}
  
  public SoftEdgeImpl(DocumentFormat.OpenXml.Drawing.SoftEdge openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Radius
  /// </summary>
  public Int64? Radius
  {
    get => (System.Int64?)OpenXmlElement?.Radius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Radius = (System.Int64?)value;
    }
  }
  
}
