namespace DocumentModel.Math;

/// <summary>
/// Matrix Row.
/// </summary>
public interface IMatrixRow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Math.IBase>? Bases { get ; set; }
  
}
