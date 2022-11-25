namespace DocumentModel.Office2010.Ink;

/// <summary>
/// Defines the ContextLinkType Class.
/// </summary>
public interface IContextLinkType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// direction
  /// </summary>
  public DocumentModel.Office2010.Ink.LinkDirectionKind? Direction { get ; set; }
  
  /// <summary>
  /// ref
  /// </summary>
  public System.String? Reference { get ; set; }
  
}
