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
  
  /// <summary>
  /// Last Known Date in XML Schema DateTime Format
  /// </summary>
  public DateTime? FullDate
  {
    get => (DateTime?)OpenXmlElement?.FullDate?.Value;
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DateFormat>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DateFormat>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.String?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.DateFormat{ Val = (System.String?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Date Picker Language ID.
  /// </summary>
  public String? LanguageId
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LanguageId>();
        return (String?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LanguageId>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.String?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.LanguageId{ Val = (System.String?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Custom XML Data Date Storage Format.
  /// </summary>
  public DateFormatKind? SdtDateMappingType
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtDateMappingType>();
        return (DateFormatKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.SdtDateMappingType>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.DateFormatValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.SdtDateMappingType{ Val = (DocumentFormat.OpenXml.Wordprocessing.DateFormatValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Date Picker Calendar Type.
  /// </summary>
  public CalendarKind? Calendar
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Calendar>();
        return (CalendarKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Calendar>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.CalendarValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Wordprocessing.Calendar{ Val = (DocumentFormat.OpenXml.Wordprocessing.CalendarValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
