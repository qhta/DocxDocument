namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Matrix Row.
/// </summary>
public class MatrixRow: ModelElement
{
  public Collection<Base>? Bases { get; set; }
}