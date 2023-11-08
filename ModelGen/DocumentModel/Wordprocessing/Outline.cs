namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this run should be displayed as if they have an outline, by drawing a one-pixel wide border around the inside and outside borders of each character glyph in the run.
/// </summary>
public partial class Outline: ModelElement<DXW.Outline>
{
  public Outline(): base(){ }
  
  public Outline(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Outline(DXW.Outline openXmlElement): base(openXmlElement) { }
  
}
