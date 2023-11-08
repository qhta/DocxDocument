namespace DocumentModel.Wordprocessing;


/// <summary>
///   Position Gutter At Top of Page.
/// </summary>
public partial class GutterAtTop: ModelElement<DXW.GutterAtTop>
{
  public GutterAtTop(): base(){ }
  
  public GutterAtTop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GutterAtTop(DXW.GutterAtTop openXmlElement): base(openXmlElement) { }
  
}
