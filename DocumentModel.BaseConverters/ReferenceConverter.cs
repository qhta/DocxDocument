namespace DocumentModel.OpenXml;

/// <summary>
///   Defines a reference. 
/// </summary>
public static class ReferenceConverter
{
  #region Reference get/set methods
  public static Reference? GetRefId<ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(ElementType).GetProperty("Id");
        Debug.Assert(valProperty != null, $"\"Id\" property in {typeof(ElementType)} not found");
        var val = valProperty.GetValue(_element);
        if (val != null)
        {
          var valType = val.GetType();
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value is not null)
          {
            if (value is string str)
              return new Reference(str);
            return new Reference(value.ToString()!);
          }
        }
      }
    }
    return null;
  }

  public static void SetRefId<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, Reference? value) where ElementType : DX.OpenXmlLeafElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element == null)
      {
        var constructor = typeof(ElementType).GetConstructor(new Type[0]);
        Debug.Assert(constructor != null, $"Type {typeof(ElementType)} must have constructor with no parameters");
        _element = (ElementType)constructor.Invoke(new object[0]);
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(ElementType).GetProperty("Id");
      Debug.Assert(valProperty != null, $"\"Id\" property in {typeof(ElementType)} not found");
      var valType = valProperty.PropertyType;
      var valueProperty = valType.GetProperty("Value");
      Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
      var val = new StringValue(value.ToString());
      valProperty.SetValue(_element, val);
    }
    else
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  #endregion
}