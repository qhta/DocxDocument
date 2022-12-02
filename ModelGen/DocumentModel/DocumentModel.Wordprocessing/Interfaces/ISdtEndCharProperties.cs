namespace DocumentModel.Wordprocessing;

/// <summary>
/// Structured Document Tag End Character Properties.
/// </summary>
public interface ISdtEndCharProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IRunProperties>? RunPropertieses { get ; set; }
  
}
