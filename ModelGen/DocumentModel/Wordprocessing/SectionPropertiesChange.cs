namespace DocumentModel.Wordprocessing;


/// <summary>
///   Revision Information for Section Properties.
/// </summary>
public partial class SectionPropertiesChange: ModelElement<DXW.SectionPropertiesChange>
{
  public SectionPropertiesChange(): base(){ }
  
  public SectionPropertiesChange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SectionPropertiesChange(DXW.SectionPropertiesChange openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Previous Section Properties.
  /// </summary>
  [DataMember]
  public DMW.PreviousSectionProperties? PreviousSectionProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.PreviousSectionProperties>();
      if (element != null)
        return PreviousSectionPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.PreviousSectionProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PreviousSectionPropertiesConverter.CreateOpenXmlElement<DXW.PreviousSectionProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
