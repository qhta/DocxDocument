namespace DocumentModel.Wordprocessing;


/// <summary>
///   Ignore Exact Line Height for Last Line on Page.
/// </summary>
public partial class SuppressBottomSpacing: ModelElement<DXW.SuppressBottomSpacing>
{
  public SuppressBottomSpacing(): base(){ }
  
  public SuppressBottomSpacing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SuppressBottomSpacing(DXW.SuppressBottomSpacing openXmlElement): base(openXmlElement) { }
  
}
