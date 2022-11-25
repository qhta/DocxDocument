namespace DocumentModel.Vml.Office;

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
  public DocumentModel.Vml.Office.RuleKind? Type { get ; set; }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  public DocumentModel.Vml.Office.AlignmentKind? How { get ; set; }
  
  /// <summary>
  /// Rule Shape Reference
  /// </summary>
  public System.String? ShapeReference { get ; set; }
  
}
