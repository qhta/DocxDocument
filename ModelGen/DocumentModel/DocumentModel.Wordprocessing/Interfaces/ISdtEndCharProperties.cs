namespace DocumentModel.Wordprocessing;

/// <summary>
/// Structured Document Tag End Character Properties.
/// </summary>
public interface ISdtEndCharProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Wordprocessing.IRunProperties? RunProperties { get ; set; }
  
}
