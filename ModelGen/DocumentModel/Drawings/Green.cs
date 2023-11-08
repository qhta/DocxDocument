namespace DocumentModel.Drawings;


/// <summary>
///   This elements specifies the input color with the specified green component, but with its red and blue color components unchanged.
/// </summary>
public partial class Green: ModelElement<DXD.Green>
{
  public Green(): base(){ }
  
  public Green(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Green(DXD.Green openXmlElement): base(openXmlElement) { }
  
}
