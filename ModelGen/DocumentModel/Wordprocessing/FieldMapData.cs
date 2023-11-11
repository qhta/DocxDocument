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
      return _Element?.GetObject<DMW.Name,DXW.Name>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Name,DXW.Name>(value);
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
      return _Element?.GetObject<DMW.MappedName,DXW.MappedName>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MappedName,DXW.MappedName>(value);
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
      return _Element?.GetObject<DMW.ColumnIndex,DXW.ColumnIndex>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ColumnIndex,DXW.ColumnIndex>(value);
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
      StringValueConverter.SetValue<DXW.LanguageId>(_ExistingElement, value);
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
      return _Element?.GetObject<DMW.DynamicAddress,DXW.DynamicAddress>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DynamicAddress,DXW.DynamicAddress>(value);
    }
  }
  
}
