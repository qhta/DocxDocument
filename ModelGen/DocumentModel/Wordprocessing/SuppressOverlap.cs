namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether a text frame which intersects another text frame at display time shall be allowed to overlap the contents of the other text frame. If a text frame cannot overlap other text frames, it shall be repositioned when displayed to prevent this overlap as needed.
/// </summary>
public partial class SuppressOverlap: ModelElement<DXW.SuppressOverlap>
{
  public SuppressOverlap(): base(){ }
  
  public SuppressOverlap(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SuppressOverlap(DXW.SuppressOverlap openXmlElement): base(openXmlElement) { }
  
}
