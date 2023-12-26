namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the set of major fonts which are to be used under different languages or locals.
/// </summary>
public partial class MajorFont: ModelElement<DXD.MajorFont>
{
  public MajorFont(): base(){ }
  
  public MajorFont(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MajorFont(DXD.MajorFont openXmlElement): base(openXmlElement) { }
  
}
