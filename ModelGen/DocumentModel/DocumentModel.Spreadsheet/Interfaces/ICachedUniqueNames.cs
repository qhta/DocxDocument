namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CachedUniqueNames Class.
/// </summary>
public interface ICachedUniqueNames // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICachedUniqueName>? CachedUniqueNames { get ; set; }
  
}
