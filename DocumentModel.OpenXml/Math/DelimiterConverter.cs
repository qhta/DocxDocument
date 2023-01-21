namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Delimiter Function.
/// </summary>
public static class DelimiterConverter
{
  /// <summary>
  /// Delimiter Properties.
  /// </summary>
  private static DMMath.DelimiterProperties? GetDelimiterProperties(DXMath.Delimiter openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.DelimiterProperties>();
    if (itemElement != null)
      return DMXMath.DelimiterPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDelimiterProperties(DXMath.Delimiter openXmlElement, DMMath.DelimiterProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.DelimiterProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.DelimiterPropertiesConverter.CreateOpenXmlElement<DXMath.DelimiterProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMMath.Base> GetBases(DXMath.Delimiter openXmlElement)
  {
    var collection = new Collection<DMMath.Base>();
    foreach (var item in openXmlElement.Elements<DXMath.Base>())
    {
      var newItem = DMXMath.BaseConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetBases(DXMath.Delimiter openXmlElement, Collection<DMMath.Base>? value)
  {
    openXmlElement.RemoveAllChildren<DXMath.Base>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXMath.BaseConverter.CreateOpenXmlElement<DXMath.Base>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMMath.Delimiter? CreateModelElement(DXMath.Delimiter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.Delimiter();
      value.DelimiterProperties = GetDelimiterProperties(openXmlElement);
      value.Bases = GetBases(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.Delimiter? value)
    where OpenXmlElementType: DXMath.Delimiter, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDelimiterProperties(openXmlElement, value?.DelimiterProperties);
      SetBases(openXmlElement, value?.Bases);
      return openXmlElement;
    }
    return default;
  }
}
