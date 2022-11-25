namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Grammar Class.
/// </summary>
public interface IGrammar // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// ref
  /// </summary>
  public System.String? Reference { get ; set; }
  
}
