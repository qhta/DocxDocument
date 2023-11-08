namespace DocumentModel.Wordprocessing;


/// <summary>
///   Use Cached Paragraph Information for Column Balancing.
/// </summary>
public partial class CachedColumnBalance: ModelElement<DXW.CachedColumnBalance>
{
  public CachedColumnBalance(): base(){ }
  
  public CachedColumnBalance(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CachedColumnBalance(DXW.CachedColumnBalance openXmlElement): base(openXmlElement) { }
  
}
