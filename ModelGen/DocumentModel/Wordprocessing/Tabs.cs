namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a sequence of custom tab stops which shall be used for any tab characters in the current paragraph.
/// </summary>
public partial class Tabs: ModelElement<DXW.Tabs>
{
  public Tabs(): base(){ }
  
  public Tabs(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Tabs(DXW.Tabs openXmlElement): base(openXmlElement) { }
  
}
