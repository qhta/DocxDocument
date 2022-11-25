namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Connection.
/// </summary>
public interface IConnection // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Model Identifier
  /// </summary>
  public System.String? ModelId { get ; set; }
  
  /// <summary>
  /// Point Type
  /// </summary>
  public DocumentModel.Drawing.Diagrams.ConnectionKind? Type { get ; set; }
  
  /// <summary>
  /// Source Identifier
  /// </summary>
  public System.String? SourceId { get ; set; }
  
  /// <summary>
  /// Destination Identifier
  /// </summary>
  public System.String? DestinationId { get ; set; }
  
  /// <summary>
  /// Source Position
  /// </summary>
  public System.UInt32? SourcePosition { get ; set; }
  
  /// <summary>
  /// Destination Position
  /// </summary>
  public System.UInt32? DestinationPosition { get ; set; }
  
  /// <summary>
  /// Parent Transition Identifier
  /// </summary>
  public System.String? ParentTransitionId { get ; set; }
  
  /// <summary>
  /// Sibling Transition Identifier
  /// </summary>
  public System.String? SiblingTransitionId { get ; set; }
  
  /// <summary>
  /// Presentation Identifier
  /// </summary>
  public System.String? PresentationId { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
