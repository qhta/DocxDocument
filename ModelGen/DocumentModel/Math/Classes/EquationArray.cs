namespace DocumentModel.Math;


/// <summary>
///   Equation-Array Function.
/// </summary>
public partial class EquationArray
{
  
  /// <summary>
  ///   Equation Array Properties.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Math.EquationArrayProperties? EquationArrayProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.Math.Base>? Items { get; set; }
  
}
