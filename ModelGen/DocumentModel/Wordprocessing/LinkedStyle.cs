namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the pairing of styles which comprise a linked style. A linked style is a grouping of a paragraph style and character style which is used in a user interface to allow the same set of formatting properties to be applied:
/// </summary>
public partial class LinkedStyle: ModelElement<DXW.LinkedStyle>
{
  public LinkedStyle(): base(){ }
  
  public LinkedStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LinkedStyle(DXW.LinkedStyle openXmlElement): base(openXmlElement) { }
  
}
