namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the RunPropertiesChange Class.
/// </summary>
public static class RunPropertiesChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.RunPropertiesChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DXW.RunPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.RunPropertiesChange openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DXW.RunPropertiesChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.RunPropertiesChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.RunPropertiesChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Run Properties.
  /// </summary>
  private static DMW.PreviousRunProperties? GetPreviousRunProperties(DXW.RunPropertiesChange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PreviousRunProperties>();
    if (itemElement != null)
      return DMXW.PreviousRunPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPreviousRunProperties(DXW.RunPropertiesChange openXmlElement, DMW.PreviousRunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousRunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousRunPropertiesConverter.CreateOpenXmlElement<DXW.PreviousRunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.RunPropertiesChange? CreateModelElement(DXW.RunPropertiesChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RunPropertiesChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousRunProperties = GetPreviousRunProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.RunPropertiesChange? value)
    where OpenXmlElementType: DXW.RunPropertiesChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousRunProperties(openXmlElement, value?.PreviousRunProperties);
      return openXmlElement;
    }
    return default;
  }
}
