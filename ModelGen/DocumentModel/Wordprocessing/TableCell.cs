namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a single cell in a table row, which contains the table’s content. Table cells in WordprocessingML are analogous to HTML td elements.
/// </summary>
public partial class TableCell: ModelElement<DXW.TableCell>
{
  public TableCell(): base(){ }
  
  public TableCell(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCell(DXW.TableCell openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Cell Properties.
  /// </summary>
  [DataMember]
  public DMW.TableCellProperties? TableCellProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableCellProperties>();
      if (element != null)
        return TableCellPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellPropertiesConverter.CreateOpenXmlElement<DXW.TableCellProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
