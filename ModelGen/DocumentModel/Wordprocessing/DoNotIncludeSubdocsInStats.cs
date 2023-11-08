namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Include Content in Text Boxes, Footnotes, and Endnotes in Document Statistics.
/// </summary>
public partial class DoNotIncludeSubdocsInStats: ModelElement<DXW.DoNotIncludeSubdocsInStats>
{
  public DoNotIncludeSubdocsInStats(): base(){ }
  
  public DoNotIncludeSubdocsInStats(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotIncludeSubdocsInStats(DXW.DoNotIncludeSubdocsInStats openXmlElement): base(openXmlElement) { }
  
}
