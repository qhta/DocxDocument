namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Argument Properties.
/// </summary>
public static class ArgumentPropertiesConverter
{
  /// <summary>
  /// Argument Size.
  /// </summary>
  private static Int64? GetArgumentSize(DXMath.ArgumentProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.ArgumentSize>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetArgumentSize(DXMath.ArgumentProperties openXmlElement, Int64? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.ArgumentSize>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXMath.ArgumentSize{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.ArgumentProperties? CreateModelElement(DXMath.ArgumentProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.ArgumentProperties();
      value.ArgumentSize = GetArgumentSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.ArgumentProperties? value)
    where OpenXmlElementType: DXMath.ArgumentProperties, new()
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
