namespace DocumentModel.Math;


/// <summary>
///   Defines the Run Class.
/// </summary>
public partial class Run
{
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public DocumentModel.Math.RunProperties? MathRunProperties { get; set; }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.RunProperties? RunProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
