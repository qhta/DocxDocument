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
  
  public DocumentModel.Wordprocessing.RunProperties? RunProperties
  {
    get;
    set;
  }
  
  public DocumentModel.Wordprocessing.InsertedMathControl? InsertedMathControl
  {
    get;
    set;
  }
  
  public DocumentModel.Wordprocessing.DeletedMathControl? DeletedMathControl
  {
    get;
    set;
  }
  
  public DocumentModel.Wordprocessing.MoveFromMathControl? MoveFromMathControl
  {
    get;
    set;
  }
  
  public DocumentModel.Wordprocessing.MoveToMathControl? MoveToMathControl
  {
    get;
    set;
  }
  
}
