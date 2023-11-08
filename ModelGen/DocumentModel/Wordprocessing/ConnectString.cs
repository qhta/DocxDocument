namespace DocumentModel.Wordprocessing;


/// <summary>
///   Data Source Connection String.
/// </summary>
public partial class ConnectString: ModelElement<DXW.ConnectString>
{
  public ConnectString(): base(){ }
  
  public ConnectString(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConnectString(DXW.ConnectString openXmlElement): base(openXmlElement) { }
  
}
