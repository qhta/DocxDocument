namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this paragraph are at least partly rendered on the same page as the following paragraph whenever possible.
/// </summary>
public partial class KeepNext: ModelElement<DXW.KeepNext>
{
  public KeepNext(): base(){ }
  
  public KeepNext(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public KeepNext(DXW.KeepNext openXmlElement): base(openXmlElement) { }
  
}
