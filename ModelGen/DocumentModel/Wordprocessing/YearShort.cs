namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a date block at the current location in the run content. A date block is a non-editable region of text which shall display the current date filtered through the specified date picture (see following paragraphs).
/// </summary>
public partial class YearShort: ModelElement<DXW.YearShort>
{
  public YearShort(): base(){ }
  
  public YearShort(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public YearShort(DXW.YearShort openXmlElement): base(openXmlElement) { }
  
}
