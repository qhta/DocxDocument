namespace DocumentModel.Wordprocessing;


/// <summary>
///   Revision Information for Table-Level Property Exceptions.
/// </summary>
public partial class TablePropertyExceptionsChange: ModelElement<DXW.TablePropertyExceptionsChange>
{
  public TablePropertyExceptionsChange(): base(){ }
  
  public TablePropertyExceptionsChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TablePropertyExceptionsChange(DXW.TablePropertyExceptionsChange openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Previous Table-Level Property Exceptions.
  /// </summary>
  [DataMember]
  public DMW.PreviousTablePropertyExceptions? PreviousTablePropertyExceptions
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.PreviousTablePropertyExceptions>();
      if (element != null)
        return PreviousTablePropertyExceptionsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PreviousTablePropertyExceptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousTablePropertyExceptionsConverter.CreateOpenXmlElement<DXW.PreviousTablePropertyExceptions>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
