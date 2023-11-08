namespace DocumentModel.Wordprocessing;


/// <summary>
///   Frameset Splitter Border Style.
/// </summary>
public partial class FlatBorders: ModelElement<DXW.FlatBorders>
{
  public FlatBorders(): base(){ }
  
  public FlatBorders(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FlatBorders(DXW.FlatBorders openXmlElement): base(openXmlElement) { }
  
}
