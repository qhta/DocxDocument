namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveToMathControl Class.
/// </summary>
public class MoveToMathControlImpl: DocumentModel.Wordprocessing.MathControlMoveTypeImpl, MoveToMathControl
{
  public new DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.MoveToMathControl?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RunProperties? RunProperties
  {
    get;
    set;
  }
  
  public InsertedMathControl? InsertedMathControl
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
