namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveFromMathControl Class.
/// </summary>
public class MoveFromMathControlImpl: DocumentModel.Wordprocessing.MathControlMoveTypeImpl, MoveFromMathControl
{
  public new DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl?)_OpenXmlElement;
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
