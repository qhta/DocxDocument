namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Mcds Class.
/// </summary>
public interface IMcds // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IMcd>? Mcds { get ; set; }
  
}
