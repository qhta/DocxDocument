namespace DocumentModel.Math;

/// <summary>
/// Matrix Row.
/// </summary>
public interface IMatrixRow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IBase>? Bases { get ; set; }
  
}
