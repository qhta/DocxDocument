namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies its input color with the specific opacity, but with its color unchanged.
/// </summary>
public partial class Alpha: ModelElement<DXD.Alpha>
{
  public Alpha(): base(){ }
  
  public Alpha(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Alpha(DXD.Alpha openXmlElement): base(openXmlElement) { }
  
}
