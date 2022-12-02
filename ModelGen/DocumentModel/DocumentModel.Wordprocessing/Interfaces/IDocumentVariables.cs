namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Variables.
/// </summary>
public interface IDocumentVariables // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IDocumentVariable>? DocumentVariables { get ; set; }
  
}
