namespace DocumentModel.Wordprocessing;


/// <summary>
///   Comment Information Block.
/// </summary>
public partial class AnnotationReferenceMark: ModelElement<DXW.AnnotationReferenceMark>
{
  public AnnotationReferenceMark(): base(){ }
  
  public AnnotationReferenceMark(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AnnotationReferenceMark(DXW.AnnotationReferenceMark openXmlElement): base(openXmlElement) { }
  
}
