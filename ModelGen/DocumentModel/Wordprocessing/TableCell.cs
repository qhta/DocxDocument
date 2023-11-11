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
      return _Element?.GetObject<DMW.TableCellProperties,DXW.TableCellProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellProperties,DXW.TableCellProperties>(value);
    }
  }
  
}
