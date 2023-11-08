namespace DocumentModel.Wordprocessing;


/// <summary>
///   Revision Information for Table Row Properties.
/// </summary>
public partial class TableRowPropertiesChange: ModelElement<DXW.TableRowPropertiesChange>
{
  public TableRowPropertiesChange(): base(){ }
  
  public TableRowPropertiesChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableRowPropertiesChange(DXW.TableRowPropertiesChange openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Previous Table Row Properties.
  /// </summary>
  [DataMember]
  public DMW.PreviousTableRowProperties? PreviousTableRowProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.PreviousTableRowProperties>();
      if (element != null)
        return PreviousTableRowPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PreviousTableRowProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousTableRowPropertiesConverter.CreateOpenXmlElement<DXW.PreviousTableRowProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
