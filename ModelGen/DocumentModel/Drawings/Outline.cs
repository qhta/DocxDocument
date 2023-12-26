namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an outline style that can be applied to a number of different objects such as shapes and text. The line allows for the specifying of many different types of outlines including even line dashes and bevels.
/// </summary>
public partial class Outline: ModelElement<DXD.Outline>
{
  public Outline(): base(){ }
  
  public Outline(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Outline(DXD.Outline openXmlElement): base(openXmlElement) { }
  
}
