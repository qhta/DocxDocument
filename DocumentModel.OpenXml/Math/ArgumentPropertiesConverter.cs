namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Argument Properties.
/// </summary>
public static class ArgumentPropertiesConverter
{
  /// <summary>
  /// Argument Size.
  /// </summary>
  public static Int64? GetArgumentSize(DocumentFormat.OpenXml.Math.ArgumentProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetArgumentSize(DocumentFormat.OpenXml.Math.ArgumentProperties? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ArgumentSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Math.ArgumentSize{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Math.ArgumentProperties? CreateModelElement(DocumentFormat.OpenXml.Math.ArgumentProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.ArgumentProperties();
      value.ArgumentSize = GetArgumentSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.ArgumentProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.ArgumentProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetArgumentSize(openXmlElement, value?.ArgumentSize);
      return openXmlElement;
    }
    return default;
  }
}
