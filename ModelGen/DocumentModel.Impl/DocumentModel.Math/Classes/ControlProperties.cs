namespace DocumentModel.Math;

/// <summary>
/// Control Properties.
/// </summary>
public class ControlPropertiesImpl: ModelElementImpl, ControlProperties
{
  public DocumentFormat.OpenXml.Math.ControlProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.ControlProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ControlPropertiesImpl(): base() {}
  
  public ControlPropertiesImpl(DocumentFormat.OpenXml.Math.ControlProperties openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Wordprocessing.MoveFromMathControl? MoveFromMathControl
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Wordprocessing.MoveToMathControl? MoveToMathControl
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
