namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the set of minor fonts that are to be used under different languages or locals.
/// </summary>
public partial class MinorFont: ModelElement<DXD.MinorFont>
{
  public MinorFont(): base(){ }
  
  public MinorFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MinorFont(DXD.MinorFont openXmlElement): base(openXmlElement) { }
  
}
