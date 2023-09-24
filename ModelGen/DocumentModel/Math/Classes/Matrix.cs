namespace DocumentModel.Math;


/// <summary>
///   Matrix Function.
/// </summary>
public partial class Matrix
{
  
  /// <summary>
  ///   Matrix Properties.
  /// </summary>
  public MatrixProperties? MatrixProperties { get; set; }
  
  public ElementCollection<MatrixRow>? Items { get; set; }
  
}
