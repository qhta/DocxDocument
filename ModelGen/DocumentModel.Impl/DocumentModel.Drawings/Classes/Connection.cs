namespace DocumentModel.Drawings;

/// <summary>
/// Connection.
/// </summary>
public class ConnectionImpl: ModelElementImpl, Connection
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Connection? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Connection?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ConnectionImpl(): base() {}
  
  public ConnectionImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Connection openXmlElement): base(openXmlElement)
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
  public DocumentModel.Drawings.ConnectionKind? Type
  {
    get => (DocumentModel.Drawings.ConnectionKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Drawing.Diagrams.ConnectionValues?)value;
    }
  }
  
  /// <summary>
  /// Source Identifier
  /// </summary>
  public String? SourceId
  {
    get => (System.String?)OpenXmlElement?.SourceId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SourceId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Destination Identifier
  /// </summary>
  public String? DestinationId
  {
    get => (System.String?)OpenXmlElement?.DestinationId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DestinationId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Source Position
  /// </summary>
  public UInt32? SourcePosition
  {
    get => (System.UInt32?)OpenXmlElement?.SourcePosition?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SourcePosition = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Destination Position
  /// </summary>
  public UInt32? DestinationPosition
  {
    get => (System.UInt32?)OpenXmlElement?.DestinationPosition?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DestinationPosition = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Parent Transition Identifier
  /// </summary>
  public String? ParentTransitionId
  {
    get => (System.String?)OpenXmlElement?.ParentTransitionId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ParentTransitionId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Sibling Transition Identifier
  /// </summary>
  public String? SiblingTransitionId
  {
    get => (System.String?)OpenXmlElement?.SiblingTransitionId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SiblingTransitionId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Presentation Identifier
  /// </summary>
  public String? PresentationId
  {
    get => (System.String?)OpenXmlElement?.PresentationId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresentationId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
