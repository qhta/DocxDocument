namespace DocumentModel.Drawing;

/// <summary>
/// Category List.
/// </summary>
public interface ICategoryList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICategory>? Categories { get ; set; }
  
}
