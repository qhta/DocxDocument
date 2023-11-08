namespace DocumentModel.Wordprocessing;


/// <summary>
///   Treat Backslash Quotation Delimiter as Two Quotation Marks.
/// </summary>
public partial class ConvertMailMergeEscape: ModelElement<DXW.ConvertMailMergeEscape>
{
  public ConvertMailMergeEscape(): base(){ }
  
  public ConvertMailMergeEscape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConvertMailMergeEscape(DXW.ConvertMailMergeEscape openXmlElement): base(openXmlElement) { }
  
}
