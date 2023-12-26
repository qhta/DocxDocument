namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a reference to a line style within the style matrix.  The idx attribute refers the index of a line style within the fillStyleLst element.
/// </summary>
public partial class LineReference: ModelElement<DXD.LineReference>
{
  public LineReference(): base(){ }
  
  public LineReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineReference(DXD.LineReference openXmlElement): base(openXmlElement) { }
  
}
