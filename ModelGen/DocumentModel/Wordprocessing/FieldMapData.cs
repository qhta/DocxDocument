namespace DocumentModel.Wordprocessing;


/// <summary>
///   External Data Source to Merge Field Mapping.
/// </summary>
public partial class FieldMapData: ModelElement<DXW.FieldMapData>
{
  public FieldMapData(): base(){ }
  
  public FieldMapData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FieldMapData(DXW.FieldMapData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Merge Field Mapping.
  /// </summary>
  [DataMember]
  public DMW.MailMergeOdsoFieldKind? MailMergeFieldType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues, DMW.MailMergeOdsoFieldKind>(_ExistingElement.GetFirstChild<DXW.MailMergeFieldType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MailMergeFieldType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues, DMW.MailMergeOdsoFieldKind>(itemElement, (DMW.MailMergeOdsoFieldKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.MailMergeFieldType, DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues, DMW.MailMergeOdsoFieldKind>((DMW.MailMergeOdsoFieldKind)value));
    }
  }
  
  
  /// <summary>
  ///   Data Source Name for Column.
  /// </summary>
  [DataMember]
  public DMW.Name? Name
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Name>();
      if (element != null)
        return NameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Name>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NameConverter.CreateOpenXmlElement<DXW.Name>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Predefined Merge Field Name.
  /// </summary>
  [DataMember]
  public DMW.MappedName? MappedName
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.MappedName>();
      if (element != null)
        return MappedNameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MappedName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MappedNameConverter.CreateOpenXmlElement<DXW.MappedName>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Index of Column Being Mapped.
  /// </summary>
  [DataMember]
  public DMW.ColumnIndex? ColumnIndex
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ColumnIndex>();
      if (element != null)
        return ColumnIndexConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ColumnIndex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColumnIndexConverter.CreateOpenXmlElement<DXW.ColumnIndex>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Merge Field Name Language ID.
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
  ///   Use Country/Region-Based Address Field Ordering.
  /// </summary>
  [DataMember]
  public DMW.DynamicAddress? DynamicAddress
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DynamicAddress>();
      if (element != null)
        return DynamicAddressConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DynamicAddress>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DynamicAddressConverter.CreateOpenXmlElement<DXW.DynamicAddress>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
