namespace DocumentModel.Wordprocessing;


/// <summary>
///   Script Function to Execute on Form Field Entry.
/// </summary>
public partial class EntryMacro: ModelElement<DXW.EntryMacro>
{
  public EntryMacro(): base(){ }
  
  public EntryMacro(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EntryMacro(DXW.EntryMacro openXmlElement): base(openXmlElement) { }
  
}
