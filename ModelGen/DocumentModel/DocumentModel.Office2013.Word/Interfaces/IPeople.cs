namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the People Class.
/// </summary>
public interface IPeople // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2013.Word.IPerson>? Persons { get ; set; }
  
}
