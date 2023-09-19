namespace DocumentModel.Math;


/// <summary>
///   Matrix Function.
/// </summary>
public partial class Matrix
{
  
  /// <summary>
  ///   Matrix Properties.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Math.MatrixProperties? MatrixProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Math.MatrixRow>? Items { get; set; }
  
}
