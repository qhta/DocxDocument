namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the current table row shall be repeated at the top of each new page on which part of this table is displayed. This gives this table row the behavior of a 'header' row on each of these pages. This element can be applied to any number of rows at the top of the table structure in order to generate multi-row table headers.
/// </summary>
public partial class TableHeader: ModelElement<DXW.TableHeader>
{
  public TableHeader(): base(){ }
  
  public TableHeader(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableHeader(DXW.TableHeader openXmlElement): base(openXmlElement) { }
  
}
