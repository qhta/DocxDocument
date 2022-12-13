namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDate Class.
/// </summary>
public class SdtContentDateImpl: ModelElementImpl, SdtContentDate
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtContentDate? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtContentDate?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SdtContentDateImpl(): base() {}
  
  public SdtContentDateImpl(DocumentFormat.OpenXml.Wordprocessing.SdtContentDate openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Last Known Date in XML Schema DateTime Format
  /// </summary>
  public DateTime? FullDate
  {
    get => (System.DateTime?)OpenXmlElement?.FullDate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FullDate = (System.DateTime?)value;
    }
  }
  
  /// <summary>
  /// Date Display Mask.
  /// </summary>
  public String? DateFormat
  {
    get => (System.String?)OpenXmlElement?.DateFormat?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.DateFormat != null)
        {
          if (value is not null)
            OpenXmlElement.DateFormat.Val = (System.String?)value;
          else
            OpenXmlElement.DateFormat = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.DateFormat = new DocumentFormat.OpenXml.Wordprocessing.DateFormat{ Val = (System.String?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Date Picker Language ID.
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
  /// Custom XML Data Date Storage Format.
  /// </summary>
  public DocumentModel.Wordprocessing.DateFormatKind? SdtDateMappingType
  {
    get => (DocumentModel.Wordprocessing.DateFormatKind?)OpenXmlElement?.SdtDateMappingType?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.SdtDateMappingType != null)
        {
          if (value is not null)
            OpenXmlElement.SdtDateMappingType.Val = (DocumentFormat.OpenXml.Wordprocessing.DateFormatValues?)value;
          else
            OpenXmlElement.SdtDateMappingType = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.SdtDateMappingType = new DocumentFormat.OpenXml.Wordprocessing.SdtDateMappingType{ Val = (DocumentFormat.OpenXml.Wordprocessing.DateFormatValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Date Picker Calendar Type.
  /// </summary>
  public DocumentModel.Wordprocessing.CalendarKind? Calendar
  {
    get => (DocumentModel.Wordprocessing.CalendarKind?)OpenXmlElement?.Calendar?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Calendar != null)
        {
          if (value is not null)
            OpenXmlElement.Calendar.Val = (DocumentFormat.OpenXml.Wordprocessing.CalendarValues?)value;
          else
            OpenXmlElement.Calendar = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Calendar = new DocumentFormat.OpenXml.Wordprocessing.Calendar{ Val = (DocumentFormat.OpenXml.Wordprocessing.CalendarValues?)value };
        }
      }
    }
  }
  
}
