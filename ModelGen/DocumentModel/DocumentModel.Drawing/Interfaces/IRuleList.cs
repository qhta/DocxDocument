namespace DocumentModel.Drawing;

/// <summary>
/// Rule List.
/// </summary>
public interface IRuleList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IRule>? Rules { get ; set; }
  
}
