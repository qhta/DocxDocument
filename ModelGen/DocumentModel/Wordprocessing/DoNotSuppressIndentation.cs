namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Ignore Floating Objects When Calculating Paragraph Indentation.
/// </summary>
public partial class DoNotSuppressIndentation: ModelElement<DXW.DoNotSuppressIndentation>
{
  public DoNotSuppressIndentation(): base(){ }
  
  public DoNotSuppressIndentation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotSuppressIndentation(DXW.DoNotSuppressIndentation openXmlElement): base(openXmlElement) { }
  
}
