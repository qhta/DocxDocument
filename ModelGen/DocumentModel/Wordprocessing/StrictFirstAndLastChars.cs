namespace DocumentModel.Wordprocessing;


/// <summary>
///   Use Strict Kinsoku Rules for Japanese Text.
/// </summary>
public partial class StrictFirstAndLastChars: ModelElement<DXW.StrictFirstAndLastChars>
{
  public StrictFirstAndLastChars(): base(){ }
  
  public StrictFirstAndLastChars(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StrictFirstAndLastChars(DXW.StrictFirstAndLastChars openXmlElement): base(openXmlElement) { }
  
}
