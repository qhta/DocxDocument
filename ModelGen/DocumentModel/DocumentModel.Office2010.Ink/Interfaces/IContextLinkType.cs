namespace DocumentModel.Office2010.Ink;

/// <summary>
/// Defines the ContextLinkType Class.
/// </summary>
public interface IContextLinkType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// direction
  /// </summary>
  public LinkDirectionValues? Direction { get ; set; }
  
  /// <summary>
  /// ref
  /// </summary>
  public String? Reference { get ; set; }
  
}
