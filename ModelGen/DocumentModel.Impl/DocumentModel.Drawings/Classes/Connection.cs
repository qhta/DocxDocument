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
  
  /// <summary>
  /// Model Identifier
  /// </summary>
  public String? ModelId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public ConnectionKind? Type
  {
    get => (ConnectionKind?)OpenXmlElement?.Type?.Value;
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
    get;
    set;
  }
  
  /// <summary>
  /// Destination Identifier
  /// </summary>
  public String? DestinationId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Source Position
  /// </summary>
  public UInt32? SourcePosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Destination Position
  /// </summary>
  public UInt32? DestinationPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Parent Transition Identifier
  /// </summary>
  public String? ParentTransitionId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sibling Transition Identifier
  /// </summary>
  public String? SiblingTransitionId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Presentation Identifier
  /// </summary>
  public String? PresentationId
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList3? ExtensionList
  {
    get;
    set;
  }
  
}
