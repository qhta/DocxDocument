namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Connection.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Diagrams.IExtensionList))]
public interface IConnection // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  public string? ModelId { get ; set; }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public ConnectionValues? Type { get ; set; }
  
  /// <summary>
  /// Source Identifier
  /// </summary>
  public string? SourceId { get ; set; }
  
  /// <summary>
  /// Destination Identifier
  /// </summary>
  public string? DestinationId { get ; set; }
  
  /// <summary>
  /// Source Position
  /// </summary>
  public uint? SourcePosition { get ; set; }
  
  /// <summary>
  /// Destination Position
  /// </summary>
  public uint? DestinationPosition { get ; set; }
  
  /// <summary>
  /// Parent Transition Identifier
  /// </summary>
  public string? ParentTransitionId { get ; set; }
  
  /// <summary>
  /// Sibling Transition Identifier
  /// </summary>
  public string? SiblingTransitionId { get ; set; }
  
  /// <summary>
  /// Presentation Identifier
  /// </summary>
  public string? PresentationId { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.Diagrams.IExtensionList? ExtensionList { get ; set; }
  
}
