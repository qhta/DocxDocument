namespace DocumentModel.Math;

/// <summary>
/// Matrix Row.
/// </summary>
public partial interface MatrixRow
{
  public Collection<DocumentModel.Math.Base>? Bases { get; set; }
  
}
