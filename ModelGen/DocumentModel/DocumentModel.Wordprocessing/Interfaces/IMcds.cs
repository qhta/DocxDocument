namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Mcds Class.
/// </summary>
public interface IMcds // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Wordprocessing.IMcd>? Mcds { get ; set; }
  
}
