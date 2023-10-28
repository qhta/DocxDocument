namespace DocumentModel.Drawings;


/// <summary>
///   Text Run.
/// </summary>
public partial class Run
{
  
  /// <summary>
  ///   Text Character Properties.
  /// </summary>
  public DMD.RunProperties? RunProperties { get; set; }
  
  
  /// <summary>
  ///   Text String.
  /// </summary>
  public DMD.Text? Text { get; set; }
  
}
