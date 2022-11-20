namespace DocumentModel.Vml.Office;

/// <summary>
/// Rule.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IProxy))]
public class Rule: IRule
{
  /// <summary>
  /// Rule ID
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rule Type
  /// </summary>
  public DocumentModel.Vml.Office.RuleValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Alignment Rule Type
  /// </summary>
  public AlignmentValues? How
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rule Shape Reference
  /// </summary>
  public string? ShapeReference
  {
    get;
    set;
  }
  
}
