namespace DocumentModel.Wordprocessing;


/// <summary>
///   UDL Connection String.
/// </summary>
public partial class UdlConnectionString: ModelElement<DXW.UdlConnectionString>
{
  public UdlConnectionString(): base(){ }
  
  public UdlConnectionString(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UdlConnectionString(DXW.UdlConnectionString openXmlElement): base(openXmlElement) { }
  
}
