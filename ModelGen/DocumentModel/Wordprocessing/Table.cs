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
      var element = _Element?.GetFirstChild<DXW.TableProperties>();
      if (element != null)
        return TablePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TablePropertiesConverter.CreateOpenXmlElement<DXW.TableProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.TableGrid? TableGrid
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableGrid>();
      if (element != null)
        return TableGridConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableGridConverter.CreateOpenXmlElement<DXW.TableGrid>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
