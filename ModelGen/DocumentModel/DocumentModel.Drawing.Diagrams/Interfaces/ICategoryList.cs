namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Category List.
/// </summary>
public interface ICategoryList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.ICategory>? Categories { get ; set; }
  
}
