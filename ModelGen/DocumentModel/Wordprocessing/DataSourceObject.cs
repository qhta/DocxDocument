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
      return _Element?.GetObject<DMW.UdlConnectionString,DXW.UdlConnectionString>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.UdlConnectionString,DXW.UdlConnectionString>(value);
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
      return _Element?.GetObject<DMW.DataSourceTableName,DXW.DataSourceTableName>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DataSourceTableName,DXW.DataSourceTableName>(value);
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
      return _Element?.GetObject<DMW.SourceReference,DXW.SourceReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SourceReference,DXW.SourceReference>(value);
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
      return _Element?.GetObject<DMW.ColumnDelimiter,DXW.ColumnDelimiter>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.ColumnDelimiter,DXW.ColumnDelimiter>(value);
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
      return _Element?.GetObject<DMW.FirstRowHeader,DXW.FirstRowHeader>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FirstRowHeader,DXW.FirstRowHeader>(value);
    }
  }
  
  [DataMember]
  public DMW.RecipientDataReference? RecipientDataReference
  {
    get
    {
      return _Element?.GetObject<DMW.RecipientDataReference,DXW.RecipientDataReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RecipientDataReference,DXW.RecipientDataReference>(value);
    }
  }
  
}
