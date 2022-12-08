namespace DocumentModel.Wordprocessing;

/// <summary>
/// External Data Source to Merge Field Mapping.
/// </summary>
public class FieldMapDataImpl: ModelElementImpl, FieldMapData
{
  public DocumentFormat.OpenXml.Wordprocessing.FieldMapData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FieldMapData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Merge Field Mapping.
  /// </summary>
  public MailMergeOdsoFieldKind? MailMergeFieldType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType>();
        return (MailMergeOdsoFieldKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType{ Val = (DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Data Source Name for Column.
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Predefined Merge Field Name.
  /// </summary>
  public String? MappedName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Index of Column Being Mapped.
  /// </summary>
  public UInt32? ColumnIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Merge Field Name Language ID.
  /// </summary>
  public String? LanguageId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Use Country/Region-Based Address Field Ordering.
  /// </summary>
  public Boolean? DynamicAddress
  {
    get;
    set;
  }
  
}
