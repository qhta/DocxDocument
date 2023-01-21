namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Equation-Array Function.
/// </summary>
public static class EquationArrayConverter
{
  /// <summary>
  /// Equation Array Properties.
  /// </summary>
  private static DMMath.EquationArrayProperties? GetEquationArrayProperties(DXMath.EquationArray openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXMath.EquationArrayProperties>();
    if (itemElement != null)
      return DMXMath.EquationArrayPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEquationArrayProperties(DXMath.EquationArray openXmlElement, DMMath.EquationArrayProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.EquationArrayProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXMath.EquationArrayPropertiesConverter.CreateOpenXmlElement<DXMath.EquationArrayProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMMath.Base> GetBases(DXMath.EquationArray openXmlElement)
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
  
  private static void SetBases(DXMath.EquationArray openXmlElement, Collection<DMMath.Base>? value)
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
  
  public static DMMath.EquationArray? CreateModelElement(DXMath.EquationArray? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.EquationArray();
      value.EquationArrayProperties = GetEquationArrayProperties(openXmlElement);
      value.Bases = GetBases(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.EquationArray? value)
    where OpenXmlElementType: DXMath.EquationArray, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEquationArrayProperties(openXmlElement, value?.EquationArrayProperties);
      SetBases(openXmlElement, value?.Bases);
      return openXmlElement;
    }
    return default;
  }
}
