namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Rule List.
/// </summary>
public interface IRuleList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IRule>? Rules { get ; set; }
  
}
