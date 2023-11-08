namespace DocumentModel.Wordprocessing;


/// <summary>
///   Only Print Form Field Content.
/// </summary>
public partial class PrintFormsData: ModelElement<DXW.PrintFormsData>
{
  public PrintFormsData(): base(){ }
  
  public PrintFormsData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PrintFormsData(DXW.PrintFormsData openXmlElement): base(openXmlElement) { }
  
}
