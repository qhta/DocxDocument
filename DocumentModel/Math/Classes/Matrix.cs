namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Matrix Function.
/// </summary>
public class Matrix: ModelElement, ICommonMathContent
{
  /// <summary>
  ///   Matrix Properties.
  /// </summary>
  public MatrixProperties? MatrixProperties { get; set; }

  public Collection<MatrixRow>? MatrixRows { get; set; }
}