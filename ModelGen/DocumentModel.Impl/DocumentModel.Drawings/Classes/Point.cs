namespace DocumentModel.Drawings;

/// <summary>
/// Point.
/// </summary>
public class PointImpl: ModelElementImpl, Point
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Point? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Point?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PointImpl(): base() {}
  
  public PointImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Point openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Model Identifier
  /// </summary>
  public String? ModelId
  {
    get => (System.String?)OpenXmlElement?.ModelId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ModelId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public DocumentModel.Drawings.PointKind? Type
  {
    get => (DocumentModel.Drawings.PointKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.Diagrams.PointValues?)value;
    }
  }
  
  /// <summary>
  /// Connection Identifier
  /// </summary>
  public String? ConnectionId
  {
    get => (System.String?)OpenXmlElement?.ConnectionId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConnectionId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  public DocumentModel.Drawings.PropertySet? PropertySet
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  public DocumentModel.Drawings.TextBody? TextBody
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.PtExtensionList? PtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
