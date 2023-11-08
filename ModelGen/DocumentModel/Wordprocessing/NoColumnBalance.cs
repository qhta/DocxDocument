namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Balance Text Columns within a Section.
/// </summary>
public partial class NoColumnBalance: ModelElement<DXW.NoColumnBalance>
{
  public NoColumnBalance(): base(){ }
  
  public NoColumnBalance(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoColumnBalance(DXW.NoColumnBalance openXmlElement): base(openXmlElement) { }
  
}
