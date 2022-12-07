namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the InsertedMathControl Class.
/// </summary>
public class InsertedMathControlImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.InsertedMathControl>, InsertedMathControl
{
  public RunProperties? RunProperties
  {
    get;
    set;
  }
  
  public DeletedMathControl? DeletedMathControl
  {
    get;
    set;
  }
  
}
