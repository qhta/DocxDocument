namespace DocumentModel.Wordprocessing;


/// <summary>
///   Revision Information for Table Cell Properties.
/// </summary>
public partial class TableCellPropertiesChange: ModelElement<DXW.TableCellPropertiesChange>
{
  public TableCellPropertiesChange(): base(){ }
  
  public TableCellPropertiesChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCellPropertiesChange(DXW.TableCellPropertiesChange openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   author
  /// </summary>
  [DataMember]
  public String? Author
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Author);
    }
    set
    {
      _ExistingElement.Author = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   date
  /// </summary>
  [DataMember]
  public DateTime? Date
  {
    get
    {
      return _Element?.Date?.Value;
    }
    set
    {
      _ExistingElement.Date = value;
    }
  }
  
  
  /// <summary>
  ///   dateUtc, this property is only available in Microsoft365 and later.
  /// </summary>
  [DataMember]
  public DateTime? DateUtc
  {
    get
    {
      return _Element?.DateUtc?.Value;
    }
    set
    {
      _ExistingElement.DateUtc = value;
    }
  }
  
  
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
  ///   Previous Table Cell Properties.
  /// </summary>
  [DataMember]
  public DMW.PreviousTableCellProperties? PreviousTableCellProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.PreviousTableCellProperties>();
      if (element != null)
        return PreviousTableCellPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PreviousTableCellProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousTableCellPropertiesConverter.CreateOpenXmlElement<DXW.PreviousTableCellProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
