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
  
  public MoveFromMathControlImpl(): base() {}
  
  public MoveFromMathControlImpl(DocumentFormat.OpenXml.Wordprocessing.MoveFromMathControl openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public DocumentModel.Wordprocessing.RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.InsertedMathControl? InsertedMathControl
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.DeletedMathControl? DeletedMathControl
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
