namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the MoveToMathControl Class.
/// </summary>
public partial class MoveToMathControl
{
  public DocumentModel.Wordprocessing.RunProperties? RunProperties { get; set; }
  
  public DocumentModel.Wordprocessing.InsertedMathControl? InsertedMathControl { get; set; }
  
  public DocumentModel.Wordprocessing.DeletedMathControl? DeletedMathControl { get; set; }
  
}
