namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that this paragraph shall be displayed from right to left. This property only affects the following set of paragraph-level properties:
/// </summary>
public partial class BiDi: ModelElement<DXW.BiDi>
{
  public BiDi(): base(){ }
  
  public BiDi(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BiDi(DXW.BiDi openXmlElement): base(openXmlElement) { }
  
}
