namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ViewValues enumeration.
/// </summary>
public partial class ViewValues: ModelElement<DXW.ViewValues>
{
  public ViewValues(): base(){ }
  
  public ViewValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ViewValues(DXW.ViewValues openXmlElement): base(openXmlElement) { }
  
}
