namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ClassificationOutcome Class.
/// </summary>
public partial class ClassificationOutcome: ModelElement<DXO21DDC.ClassificationOutcome>
{
  public ClassificationOutcome(): base(){ }
  
  public ClassificationOutcome(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ClassificationOutcome(DXO21DDC.ClassificationOutcome openXmlElement): base(openXmlElement) { }
  
}
