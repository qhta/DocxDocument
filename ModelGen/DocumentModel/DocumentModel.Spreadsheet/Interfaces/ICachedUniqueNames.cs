namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CachedUniqueNames Class.
/// </summary>
public interface ICachedUniqueNames // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.ICachedUniqueName>? CachedUniqueNames { get ; set; }
  
}
