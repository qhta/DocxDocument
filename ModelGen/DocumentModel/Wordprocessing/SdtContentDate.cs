namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be a date picker when displayed in the document.
/// </summary>
public partial class SdtContentDate: ModelElement<DXW.SdtContentDate>
{
  public SdtContentDate(): base(){ }
  
  public SdtContentDate(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentDate(DXW.SdtContentDate openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Last Known Date in XML Schema DateTime Format
  /// </summary>
  [DataMember]
  public DateTime? FullDate
  {
    get
    {
      return _Element?.FullDate?.Value;
    }
    set
    {
      _ExistingElement.FullDate = value;
    }
  }
  
  
  /// <summary>
  ///   Date Display Mask.
  /// </summary>
  [DataMember]
  public DMW.DateFormat? DateFormat
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DateFormat>();
      if (element != null)
        return DateFormatConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DateFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DateFormatConverter.CreateOpenXmlElement<DXW.DateFormat>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Date Picker Language ID.
  /// </summary>
  [DataMember]
  public String? LanguageId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetFirstChild<DXW.LanguageId>()?.Val);
    }
    set
    {
      StringValueConverter.SetValue<DXW.LanguageId>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Custom XML Data Date Storage Format.
  /// </summary>
  [DataMember]
  public DMW.DateFormatKind? SdtDateMappingType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DateFormatValues, DMW.DateFormatKind>(_ExistingElement.GetFirstChild<DXW.SdtDateMappingType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SdtDateMappingType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DateFormatValues, DMW.DateFormatKind>(itemElement, (DMW.DateFormatKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.SdtDateMappingType, DocumentFormat.OpenXml.Wordprocessing.DateFormatValues, DMW.DateFormatKind>((DMW.DateFormatKind)value));
    }
  }
  
  
  /// <summary>
  ///   Date Picker Calendar Type.
  /// </summary>
  [DataMember]
  public DMW.CalendarKind? Calendar
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.CalendarValues, DMW.CalendarKind>(_ExistingElement.GetFirstChild<DXW.Calendar>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Calendar>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.CalendarValues, DMW.CalendarKind>(itemElement, (DMW.CalendarKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.Calendar, DocumentFormat.OpenXml.Wordprocessing.CalendarValues, DMW.CalendarKind>((DMW.CalendarKind)value));
    }
  }
  
}
