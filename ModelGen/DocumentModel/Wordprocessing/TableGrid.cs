namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the table grid for the current table. The table grid is a definition of the set of grid columns which define all of the shared vertical edges of the table, as well as default widths for each of these grid columns. These grid column widths are then used to determine the size of the table based on the table layout algorithm used.
/// </summary>
public partial class TableGrid: ModelElement<DXW.TableGrid>
{
  public TableGrid(): base(){ }
  
  public TableGrid(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableGrid(DXW.TableGrid openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.TableGridChange? TableGridChange
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableGridChange>();
      if (element != null)
        return TableGridChangeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableGridChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableGridChangeConverter.CreateOpenXmlElement<DXW.TableGridChange>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
