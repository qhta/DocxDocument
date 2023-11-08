namespace DocumentModel.Wordprocessing;


/// <summary>
///   Ignore Minimum and Exact Line Height for First Line on Page.
/// </summary>
public partial class SuppressTopSpacing: ModelElement<DXW.SuppressTopSpacing>
{
  public SuppressTopSpacing(): base(){ }
  
  public SuppressTopSpacing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SuppressTopSpacing(DXW.SuppressTopSpacing openXmlElement): base(openXmlElement) { }
  
}
