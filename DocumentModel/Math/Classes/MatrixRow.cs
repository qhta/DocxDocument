namespace DocumentModel.Math;

/// <summary>
///   Matrix Row.
/// </summary>
public record MatrixRow
{
  public Collection<Base>? Bases { get; set; }
}