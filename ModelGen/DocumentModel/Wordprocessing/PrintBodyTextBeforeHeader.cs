namespace DocumentModel.Wordprocessing;


/// <summary>
///   Print Body Text before Header/Footer Contents.
/// </summary>
public partial class PrintBodyTextBeforeHeader: ModelElement<DXW.PrintBodyTextBeforeHeader>
{
  public PrintBodyTextBeforeHeader(): base(){ }
  
  public PrintBodyTextBeforeHeader(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PrintBodyTextBeforeHeader(DXW.PrintBodyTextBeforeHeader openXmlElement): base(openXmlElement) { }
  
}
