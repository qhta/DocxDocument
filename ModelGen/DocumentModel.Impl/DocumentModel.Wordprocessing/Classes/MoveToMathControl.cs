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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public InsertedMathControl? InsertedMathControl
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DeletedMathControl? DeletedMathControl
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
