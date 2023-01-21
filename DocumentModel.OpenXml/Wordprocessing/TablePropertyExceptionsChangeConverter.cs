namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Revision Information for Table-Level Property Exceptions.
/// </summary>
public static class TablePropertyExceptionsChangeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.TablePropertyExceptionsChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static void SetAuthor(DXW.TablePropertyExceptionsChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.TablePropertyExceptionsChange openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static void SetDate(DXW.TablePropertyExceptionsChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.TablePropertyExceptionsChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXW.TablePropertyExceptionsChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// Previous Table-Level Property Exceptions.
  /// </summary>
  private static DMW.PreviousTablePropertyExceptions? GetPreviousTablePropertyExceptions(DXW.TablePropertyExceptionsChange openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXW.PreviousTablePropertyExceptions>();
    if (itemElement != null)
      return DMXW.PreviousTablePropertyExceptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPreviousTablePropertyExceptions(DXW.TablePropertyExceptionsChange openXmlElement, DMW.PreviousTablePropertyExceptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.PreviousTablePropertyExceptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.PreviousTablePropertyExceptionsConverter.CreateOpenXmlElement<DXW.PreviousTablePropertyExceptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.TablePropertyExceptionsChange? CreateModelElement(DXW.TablePropertyExceptionsChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TablePropertyExceptionsChange();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.PreviousTablePropertyExceptions = GetPreviousTablePropertyExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.TablePropertyExceptionsChange? value)
    where OpenXmlElementType: DXW.TablePropertyExceptionsChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      SetPreviousTablePropertyExceptions(openXmlElement, value?.PreviousTablePropertyExceptions);
      return openXmlElement;
    }
    return default;
  }
}
