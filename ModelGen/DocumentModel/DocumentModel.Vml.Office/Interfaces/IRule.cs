namespace DocumentModel.Vml.Office;

/// <summary>
/// Rule.
/// </summary>
public interface IRule // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Rule ID
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  public RuleValues? Type { get ; set; }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  public AlignmentValues? How { get ; set; }
  
  /// <summary>
  /// Rule Shape Reference
  /// </summary>
  public String? ShapeReference { get ; set; }
  
}
