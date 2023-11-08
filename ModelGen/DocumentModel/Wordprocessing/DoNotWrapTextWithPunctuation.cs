namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Allow Hanging Punctuation With Character Grid.
/// </summary>
public partial class DoNotWrapTextWithPunctuation: ModelElement<DXW.DoNotWrapTextWithPunctuation>
{
  public DoNotWrapTextWithPunctuation(): base(){ }
  
  public DoNotWrapTextWithPunctuation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotWrapTextWithPunctuation(DXW.DoNotWrapTextWithPunctuation openXmlElement): base(openXmlElement) { }
  
}
