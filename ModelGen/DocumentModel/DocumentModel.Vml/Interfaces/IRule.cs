namespace DocumentModel.Vml;

/// <summary>
/// Rule.
/// </summary>
public interface IRule // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Rule ID
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  public DocumentModel.Vml.RuleKind? Type { get ; set; }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  public DocumentModel.Vml.AlignmentKind? How { get ; set; }
  
  /// <summary>
  /// Rule Shape Reference
  /// </summary>
  public System.String? ShapeReference { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Vml.IProxy>? Proxies { get ; set; }
  
}
