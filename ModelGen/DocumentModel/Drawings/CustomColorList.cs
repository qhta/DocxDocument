namespace DocumentModel.Drawings;


/// <summary>
///   This element allows for a custom color palette to be created and which shows up alongside other color schemes.  This can be very useful, for example, when someone would like to maintain a corporate color palette.
/// </summary>
public partial class CustomColorList: ModelElement<DXD.CustomColorList>
{
  public CustomColorList(): base(){ }
  
  public CustomColorList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomColorList(DXD.CustomColorList openXmlElement): base(openXmlElement) { }
  
}
