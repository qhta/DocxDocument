namespace DocumentModel.Drawings;

/// <summary>
/// Point.
/// </summary>
public class Point1Impl: ModelElementImpl, Point1
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Point? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Point?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Model Identifier
  /// </summary>
  public String? ModelId
  {
    get => (String?)OpenXmlElement?.ModelId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ModelId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public PointKind? Type
  {
    get => (PointKind?)OpenXmlElement?.Type?.Value;
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
    get => (String?)OpenXmlElement?.ConnectionId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ConnectionId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Property Set.
  /// </summary>
  public PropertySet? PropertySet
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public ShapeProperties3? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Text Body.
  /// </summary>
  public TextBody1? TextBody
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// PtExtensionList.
  /// </summary>
  public PtExtensionList? PtExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
