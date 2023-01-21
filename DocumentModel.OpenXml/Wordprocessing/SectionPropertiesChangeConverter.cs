namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Section Properties.
/// </summary>
public static class SectionPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.SectionPropertiesChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DXW.SectionPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.SectionPropertiesChange openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DXW.SectionPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.SectionPropertiesChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.SectionPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Section Properties.
  /// </summary>
  private static DMW.PreviousSectionProperties? GetPreviousSectionProperties(DXW.SectionPropertiesChange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PreviousSectionProperties>();
    if (itemElement != null)
      return DMXW.PreviousSectionPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPreviousSectionProperties(DXW.SectionPropertiesChange openXmlElement, DMW.PreviousSectionProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousSectionProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousSectionPropertiesConverter.CreateOpenXmlElement<DXW.PreviousSectionProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.SectionPropertiesChange? CreateModelElement(DXW.SectionPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SectionPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousSectionProperties = GetPreviousSectionProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SectionPropertiesChange? value)
    where OpenXmlElementType: DXW.SectionPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousSectionProperties(openXmlElement, value?.PreviousSectionProperties);
      return openXmlElement;
    }
    return default;
  }
}
