namespace DocumentModel.Wordprocessing;


/// <summary>
///   Revision Information for Table Grid Column Definitions.
/// </summary>
public partial class TableGridChange: ModelElement<DXW.TableGridChange>
{
  public TableGridChange(): base(){ }
  
  public TableGridChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableGridChange(DXW.TableGridChange openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Previous Table Grid.
  /// </summary>
  [DataMember]
  public DMW.PreviousTableGrid? PreviousTableGrid
  {
    get
    {
      return _Element?.GetObject<DMW.PreviousTableGrid,DXW.PreviousTableGrid>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.PreviousTableGrid,DXW.PreviousTableGrid>(value);
    }
  }
  
}
