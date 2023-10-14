namespace DocumentModel.Math;


/// <summary>
///   Matrix Function.
/// </summary>
public partial class Matrix
{
  
  /// <summary>
  ///   Matrix Properties.
  /// </summary>
  public DocumentModel.Math.MatrixProperties? MatrixProperties { get; set; }
  
  public DM.ElementCollection<MatrixRow>? Items { get; set; }
  
}
