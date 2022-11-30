namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the Mcds Class.
/// </summary>
public interface IMcds // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office.Word.IMcd>? Mcds { get ; set; }
  
}
