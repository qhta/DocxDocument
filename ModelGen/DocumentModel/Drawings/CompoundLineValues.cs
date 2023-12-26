namespace DocumentModel.Drawings;


/// <summary>
///   Compound Line Type
/// </summary>
public partial class CompoundLineValues: ModelElement<DXD.CompoundLineValues>
{
  public CompoundLineValues(): base(){ }
  
  public CompoundLineValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CompoundLineValues(DXD.CompoundLineValues openXmlElement): base(openXmlElement) { }
  
}
