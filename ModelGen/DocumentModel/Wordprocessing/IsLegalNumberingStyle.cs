namespace DocumentModel.Wordprocessing;


/// <summary>
///   Display All Levels Using Arabic Numerals.
/// </summary>
public partial class IsLegalNumberingStyle: ModelElement<DXW.IsLegalNumberingStyle>
{
  public IsLegalNumberingStyle(): base(){ }
  
  public IsLegalNumberingStyle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public IsLegalNumberingStyle(DXW.IsLegalNumberingStyle openXmlElement): base(openXmlElement) { }
  
}
