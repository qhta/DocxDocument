namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of a table present in the document. A table is a set of paragraphs (and other block-level content) arranged in rows and columns. Tables in WordprocessingML are defined via the tbl element, which is analogous to the HTML table tag.
/// </summary>
public partial class Table: ModelElement<DXW.Table>
{
  public Table(): base(){ }
  
  public Table(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Table(DXW.Table openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.TableProperties? TableProperties
  {
    get
    {
      return _Element?.GetObject<DMW.TableProperties,DXW.TableProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableProperties,DXW.TableProperties>(value);
    }
  }
  
  [DataMember]
  public DMW.TableGrid? TableGrid
  {
    get
    {
      return _Element?.GetObject<DMW.TableGrid,DXW.TableGrid>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableGrid,DXW.TableGrid>(value);
    }
  }
  
}
