namespace DocumentModel.Math;

/// <summary>
/// Control Properties.
/// </summary>
public interface IControlProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Wordprocessing.IRunProperties? RunProperties { get ; set; }
  
  public DocumentModel.Wordprocessing.IInsertedMathControl? InsertedMathControl { get ; set; }
  
  public DocumentModel.Wordprocessing.IDeletedMathControl? DeletedMathControl { get ; set; }
  
  public DocumentModel.Wordprocessing.IMoveFromMathControl? MoveFromMathControl { get ; set; }
  
  public DocumentModel.Wordprocessing.IMoveToMathControl? MoveToMathControl { get ; set; }
  
}
