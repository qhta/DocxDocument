namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the People Class.
/// </summary>
public interface IPeople // : DocumentModel.ITypedOpenXmlPartRootElement
{
  public Collection<IPerson>? Persons { get ; set; }
  
}
