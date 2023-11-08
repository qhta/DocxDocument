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
      var element = _Element?.GetFirstChild<DXW.PreviousTableGrid>();
      if (element != null)
        return PreviousTableGridConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PreviousTableGrid>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousTableGridConverter.CreateOpenXmlElement<DXW.PreviousTableGrid>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
