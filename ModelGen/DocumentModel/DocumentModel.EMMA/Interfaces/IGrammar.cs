namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Grammar Class.
/// </summary>
public interface IGrammar // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// ref
  /// </summary>
  public String? Reference { get ; set; }
  
}
