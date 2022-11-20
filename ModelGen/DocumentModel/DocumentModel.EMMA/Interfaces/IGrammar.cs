namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Grammar Class.
/// </summary>
public interface IGrammar // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// ref
  /// </summary>
  public string? Reference { get ; set; }
  
}
