namespace DocumentModel.Wordprocessing;


/// <summary>
///   Column Delimiter for Data Source.
/// </summary>
public partial class ColumnDelimiter: ModelElement<DXW.ColumnDelimiter>
{
  public ColumnDelimiter(): base(){ }
  
  public ColumnDelimiter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColumnDelimiter(DXW.ColumnDelimiter openXmlElement): base(openXmlElement) { }
  
}
