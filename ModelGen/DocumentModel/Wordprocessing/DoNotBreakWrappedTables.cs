namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Allow Floating Tables To Break Across Pages.
/// </summary>
public partial class DoNotBreakWrappedTables: ModelElement<DXW.DoNotBreakWrappedTables>
{
  public DoNotBreakWrappedTables(): base(){ }
  
  public DoNotBreakWrappedTables(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotBreakWrappedTables(DXW.DoNotBreakWrappedTables openXmlElement): base(openXmlElement) { }
  
}
