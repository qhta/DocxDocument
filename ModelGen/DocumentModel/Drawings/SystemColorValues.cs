namespace DocumentModel.Drawings;


/// <summary>
///   System Color Value
/// </summary>
public partial class SystemColorValues: ModelElement<DXD.SystemColorValues>
{
  public SystemColorValues(): base(){ }
  
  public SystemColorValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SystemColorValues(DXD.SystemColorValues openXmlElement): base(openXmlElement) { }
  
}
