namespace DocumentModel.Wordprocessing;


/// <summary>
///   Office Data Source Object Settings.
/// </summary>
public partial class DataSourceObject: ModelElement<DXW.DataSourceObject>
{
  public DataSourceObject(): base(){ }
  
  public DataSourceObject(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataSourceObject(DXW.DataSourceObject openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   UDL Connection String.
  /// </summary>
  [DataMember]
  public DMW.UdlConnectionString? UdlConnectionString
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.UdlConnectionString>();
      if (element != null)
        return UdlConnectionStringConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.UdlConnectionString>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UdlConnectionStringConverter.CreateOpenXmlElement<DXW.UdlConnectionString>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Data Source Table Name.
  /// </summary>
  [DataMember]
  public DMW.DataSourceTableName? DataSourceTableName
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DataSourceTableName>();
      if (element != null)
        return DataSourceTableNameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DataSourceTableName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataSourceTableNameConverter.CreateOpenXmlElement<DXW.DataSourceTableName>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ODSO Data Source File Path.
  /// </summary>
  [DataMember]
  public DMW.SourceReference? SourceReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SourceReference>();
      if (element != null)
        return SourceReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SourceReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SourceReferenceConverter.CreateOpenXmlElement<DXW.SourceReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Column Delimiter for Data Source.
  /// </summary>
  [DataMember]
  public DMW.ColumnDelimiter? ColumnDelimiter
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.ColumnDelimiter>();
      if (element != null)
        return ColumnDelimiterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ColumnDelimiter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColumnDelimiterConverter.CreateOpenXmlElement<DXW.ColumnDelimiter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ODSO Data Source Type.
  /// </summary>
  [DataMember]
  public DMW.MailMergeSourceKind? MailMergeSource
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues, DMW.MailMergeSourceKind>(_ExistingElement.GetFirstChild<DXW.MailMergeSource>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MailMergeSource>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues, DMW.MailMergeSourceKind>(itemElement, (DMW.MailMergeSourceKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.MailMergeSource, DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues, DMW.MailMergeSourceKind>((DMW.MailMergeSourceKind)value));
    }
  }
  
  
  /// <summary>
  ///   First Row of Data Source Contains Column Names.
  /// </summary>
  [DataMember]
  public DMW.FirstRowHeader? FirstRowHeader
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FirstRowHeader>();
      if (element != null)
        return FirstRowHeaderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FirstRowHeader>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FirstRowHeaderConverter.CreateOpenXmlElement<DXW.FirstRowHeader>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.RecipientDataReference? RecipientDataReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RecipientDataReference>();
      if (element != null)
        return RecipientDataReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RecipientDataReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RecipientDataReferenceConverter.CreateOpenXmlElement<DXW.RecipientDataReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
