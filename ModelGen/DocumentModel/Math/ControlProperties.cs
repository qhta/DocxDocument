namespace DocumentModel.Math;


/// <summary>
///   Control Properties.
/// </summary>
public partial class ControlProperties
{
  public DocumentModel.Wordprocessing.RunProperties? RunProperties { get; set; }
  
  public DocumentModel.Wordprocessing.InsertedMathControl? InsertedMathControl { get; set; }
  
  public DocumentModel.Wordprocessing.DeletedMathControl? DeletedMathControl { get; set; }
  
  public DocumentModel.Wordprocessing.MoveFromMathControl? MoveFromMathControl { get; set; }
  
  public DocumentModel.Wordprocessing.MoveToMathControl? MoveToMathControl { get; set; }
  
}
