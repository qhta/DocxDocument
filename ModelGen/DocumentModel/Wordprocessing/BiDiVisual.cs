namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the cells with this table shall be visually represented in a right to left direction. This element also affects the application of all table-level properties.
/// </summary>
public partial class BiDiVisual: ModelElement<DXW.BiDiVisual>
{
  public BiDiVisual(): base(){ }
  
  public BiDiVisual(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BiDiVisual(DXW.BiDiVisual openXmlElement): base(openXmlElement) { }
  
}
