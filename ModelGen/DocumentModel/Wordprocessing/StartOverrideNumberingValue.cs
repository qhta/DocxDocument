namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Level Starting Value Override.
/// </summary>
public partial class StartOverrideNumberingValue: ModelElement<DXW.StartOverrideNumberingValue>
{
  public StartOverrideNumberingValue(): base(){ }
  
  public StartOverrideNumberingValue(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StartOverrideNumberingValue(DXW.StartOverrideNumberingValue openXmlElement): base(openXmlElement) { }
  
}
