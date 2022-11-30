namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comments Collection.
/// </summary>
public interface IComments // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IComment>? Comments { get ; set; }
  
}
