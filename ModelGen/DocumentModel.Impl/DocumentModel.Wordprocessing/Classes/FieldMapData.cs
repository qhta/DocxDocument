namespace DocumentModel.Wordprocessing;

/// <summary>
/// External Data Source to Merge Field Mapping.
/// </summary>
public partial class FieldMapDataImpl: ModelElementImpl, FieldMapData
{
  public DocumentFormat.OpenXml.Wordprocessing.FieldMapData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FieldMapData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FieldMapDataImpl(): base() {}
  
  public FieldMapDataImpl(DocumentFormat.OpenXml.Wordprocessing.FieldMapData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Merge Field Mapping.
  /// </summary>
  public DocumentModel.Wordprocessing.MailMergeOdsoFieldKind? MailMergeFieldType
  {
    get => (DocumentModel.Wordprocessing.MailMergeOdsoFieldKind?)OpenXmlElement?.MailMergeFieldType?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MailMergeFieldType != null)
        {
          if (value is not null)
            OpenXmlElement.MailMergeFieldType.Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues?)value;
          else
            OpenXmlElement.MailMergeFieldType = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MailMergeFieldType = new DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType{ Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Data Source Name for Column.
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Name != null)
        {
          if (value is not null)
            OpenXmlElement.Name.Val = (System.String?)value;
          else
            OpenXmlElement.Name = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Name = new DocumentFormat.OpenXml.Wordprocessing.Name{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Predefined Merge Field Name.
  /// </summary>
  public String? MappedName
  {
    get => (System.String?)OpenXmlElement?.MappedName?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MappedName != null)
        {
          if (value is not null)
            OpenXmlElement.MappedName.Val = (System.String?)value;
          else
            OpenXmlElement.MappedName = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MappedName = new DocumentFormat.OpenXml.Wordprocessing.MappedName{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Index of Column Being Mapped.
  /// </summary>
  public UInt32? ColumnIndex
  {
    get => (System.UInt32?)OpenXmlElement?.ColumnIndex?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ColumnIndex != null)
        {
          if (value is not null)
            OpenXmlElement.ColumnIndex.Val = (System.UInt32?)value;
          else
            OpenXmlElement.ColumnIndex = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ColumnIndex = new DocumentFormat.OpenXml.Wordprocessing.ColumnIndex{ Val = (System.UInt32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Merge Field Name Language ID.
  /// </summary>
  public String? LanguageId
  {
    get => (System.String?)OpenXmlElement?.LanguageId?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.LanguageId != null)
        {
          if (value is not null)
            OpenXmlElement.LanguageId.Val = (System.String?)value;
          else
            OpenXmlElement.LanguageId = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.LanguageId = new DocumentFormat.OpenXml.Wordprocessing.LanguageId{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Use Country/Region-Based Address Field Ordering.
  /// </summary>
  public Boolean? DynamicAddress
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DynamicAddress>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DynamicAddress>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Wordprocessing.DynamicAddress();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
