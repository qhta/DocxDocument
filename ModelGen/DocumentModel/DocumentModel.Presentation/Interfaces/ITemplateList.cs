namespace DocumentModel.Presentation;

/// <summary>
/// Template effects.
/// </summary>
public interface ITemplateList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ITemplate>? Templates { get ; set; }
  
}
