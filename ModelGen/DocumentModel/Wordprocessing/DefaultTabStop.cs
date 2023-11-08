namespace DocumentModel.Wordprocessing;


/// <summary>
///   Distance Between Automatic Tab Stops.
/// </summary>
public partial class DefaultTabStop: ModelElement<DXW.DefaultTabStop>
{
  public DefaultTabStop(): base(){ }
  
  public DefaultTabStop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DefaultTabStop(DXW.DefaultTabStop openXmlElement): base(openXmlElement) { }
  
}
