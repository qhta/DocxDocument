namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Display Visual Indication of Grammatical Errors.
/// </summary>
public partial class HideGrammaticalErrors: ModelElement<DXW.HideGrammaticalErrors>
{
  public HideGrammaticalErrors(): base(){ }
  
  public HideGrammaticalErrors(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HideGrammaticalErrors(DXW.HideGrammaticalErrors openXmlElement): base(openXmlElement) { }
  
}
