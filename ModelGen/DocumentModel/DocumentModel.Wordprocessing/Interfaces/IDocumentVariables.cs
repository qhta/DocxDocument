namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Variables.
/// </summary>
public interface IDocumentVariables // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IDocumentVariable>? DocumentVariables { get ; set; }
  
}
