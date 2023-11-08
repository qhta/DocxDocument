namespace DocumentModel.Wordprocessing;


/// <summary>
///   List Separator for Field Code Evaluation.
/// </summary>
public partial class ListSeparator: ModelElement<DXW.ListSeparator>
{
  public ListSeparator(): base(){ }
  
  public ListSeparator(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ListSeparator(DXW.ListSeparator openXmlElement): base(openXmlElement) { }
  
}
