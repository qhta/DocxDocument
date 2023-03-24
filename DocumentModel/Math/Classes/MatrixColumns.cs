namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Matrix Columns.
/// </summary>
public class MatrixColumns: ModelElement
{
  public Collection<MatrixColumn>? Items { get; set; }
}