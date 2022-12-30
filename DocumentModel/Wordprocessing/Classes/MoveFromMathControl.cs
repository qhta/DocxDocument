namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveFromMathControl Class.
/// </summary>
public partial class MoveFromMathControl
{
  public DocumentModel.Wordprocessing.RunProperties? RunProperties { get; set; }
  
  public DocumentModel.Wordprocessing.InsertedMathControl? InsertedMathControl { get; set; }
  
  public DocumentModel.Wordprocessing.DeletedMathControl? DeletedMathControl { get; set; }
  
}
