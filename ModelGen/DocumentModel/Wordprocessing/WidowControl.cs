namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether a consumer shall prevent a single line of this paragraph from being displayed on a separate page from the remaining content at display time by moving the line onto the following page.
/// </summary>
public partial class WidowControl: ModelElement<DXW.WidowControl>
{
  public WidowControl(): base(){ }
  
  public WidowControl(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WidowControl(DXW.WidowControl openXmlElement): base(openXmlElement) { }
  
}
