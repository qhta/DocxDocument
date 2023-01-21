namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table Properties.
/// </summary>
public static class TablePropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.TablePropertiesChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DXW.TablePropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.TablePropertiesChange openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DXW.TablePropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.TablePropertiesChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.TablePropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Table Properties.
  /// </summary>
  private static DMW.PreviousTableProperties? GetPreviousTableProperties(DXW.TablePropertiesChange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PreviousTableProperties>();
    if (itemElement != null)
      return DMXW.PreviousTablePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPreviousTableProperties(DXW.TablePropertiesChange openXmlElement, DMW.PreviousTableProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousTableProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousTablePropertiesConverter.CreateOpenXmlElement<DXW.PreviousTableProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TablePropertiesChange? CreateModelElement(DXW.TablePropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TablePropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousTableProperties = GetPreviousTableProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TablePropertiesChange? value)
    where OpenXmlElementType: DXW.TablePropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousTableProperties(openXmlElement, value?.PreviousTableProperties);
      return openXmlElement;
    }
    return default;
  }
}
