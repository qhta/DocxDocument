namespace DocumentModel.Presentation;

/// <summary>
/// Template effects.
/// </summary>
public interface ITemplateList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Presentation.ITemplate>? Templates { get ; set; }
  
}
