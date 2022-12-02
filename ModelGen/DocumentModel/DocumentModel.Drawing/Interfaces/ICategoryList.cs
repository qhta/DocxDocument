namespace DocumentModel.Drawing;

/// <summary>
/// Category List.
/// </summary>
public interface ICategoryList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ICategory>? Categories { get ; set; }
  
}
