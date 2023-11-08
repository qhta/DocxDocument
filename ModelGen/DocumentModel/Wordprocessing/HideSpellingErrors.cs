namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Display Visual Indication of Spelling Errors.
/// </summary>
public partial class HideSpellingErrors: ModelElement<DXW.HideSpellingErrors>
{
  public HideSpellingErrors(): base(){ }
  
  public HideSpellingErrors(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HideSpellingErrors(DXW.HideSpellingErrors openXmlElement): base(openXmlElement) { }
  
}
