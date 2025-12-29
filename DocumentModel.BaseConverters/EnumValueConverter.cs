namespace DocumentModel.OpenXml;

public static class EnumValueConverter
{
  /// <summary>
  /// Gets an EnumValue from the specified OpenXmlElement that has a "Val" property of OpenXml EnumValue type.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <typeparam name="ModelEnumType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static ModelEnumType? GetEnumValue<OpenXmlEnumType, ModelEnumType>(this DX.OpenXmlElement openXmlElement)
    where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
    where ModelEnumType : struct, IConvertible
  {
    DX.EnumValue<OpenXmlEnumType>? element = openXmlElement as DX.EnumValue<OpenXmlEnumType>;
    if (element == null)
    {
      var valProp = openXmlElement.GetType().GetProperty("Val");
      element = valProp?.PropertyType as DX.EnumValue<OpenXmlEnumType>;

    }
    if (element?.Value != null)
    {
      var n = (int)System.Convert.ChangeType(element.Value, typeof(int));
      var result = (ModelEnumType)Enum.ToObject(typeof(ModelEnumType), n);
      return result;
    }
    return null;
  }

  /// <summary>
  /// Gets an EnumValue from the specified OpenXml EnumValue value.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <typeparam name="ModelEnumType"></typeparam>
  /// <param name="element"></param>
  /// <returns></returns>
  public static ModelEnumType? GetEnumValue<OpenXmlEnumType, ModelEnumType>(this DX.EnumValue<OpenXmlEnumType> element)
    where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
    where ModelEnumType : struct, IConvertible
  {
    if (element?.Value != null)
    {
      var n = (int)System.Convert.ChangeType(element.Value, typeof(int));
      var result = (ModelEnumType)Enum.ToObject(typeof(ModelEnumType), n);
      return result;
    }
    return null;
  }

  /// <summary>
  /// Gets an EnumValue from the specified OpenXml EnumValue value.
  /// </summary>
  /// <typeparam name="OpenXmlEnumValue"></typeparam>
  /// <typeparam name="ModelEnumType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  public static ModelEnumType? Convert<ModelEnumType, OpenXmlEnumValue>(OpenXmlEnumValue? value)
    where OpenXmlEnumValue : struct, IConvertible
    where ModelEnumType : struct, IConvertible
  {
    if (value != null)
    {
      var n = (int)System.Convert.ChangeType(value, typeof(int));
      var result = (ModelEnumType)Enum.ToObject(typeof(ModelEnumType), n);
      return result;
    }
    return null;
  }

  /// <summary>
  /// Creates an OpenXml EnumValue from the specified UInt16 value.
  /// </summary>
  /// <typeparam name="ModelEnumType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  public static ModelEnumType? CreateEnumValue<ModelEnumType>(this UInt16? value)
    where ModelEnumType : struct, IConvertible
  {
    if (value != null)
    {
      var n = (int)System.Convert.ChangeType(value, typeof(int));
      var val = (ModelEnumType)Enum.ToObject(typeof(ModelEnumType), n);
      return val;
    }
    return null;
  }

  /// <summary>
  /// Creates an OpenXml EnumValue from the specified ModelEnumType value.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <typeparam name="ModelEnumType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  public static DX.EnumValue<OpenXmlEnumType>? CreateEnumValue<OpenXmlEnumType, ModelEnumType>(this ModelEnumType? value)
    where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
    where ModelEnumType : struct, IConvertible
  {
    if (value != null)
    {
      var element = new DX.EnumValue<OpenXmlEnumType>();
      var n = (int)System.Convert.ChangeType(value, typeof(int));
      var val = (OpenXmlEnumType)Enum.ToObject(typeof(OpenXmlEnumType), n);
      element.Value = val;
      return element;
    }
    return null;
  }

  /// <summary>
  /// Creates an OpenXml OpenXmlElementType containing the OpenXmlEnumType "Val" property from the specified ModelEnumType value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <typeparam name="ModelEnumType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType, OpenXmlEnumType, ModelEnumType>(this ModelEnumType value)
  where OpenXmlElementType : DX.OpenXmlLeafElement, new()
  where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  where ModelEnumType : struct, IConvertible
  {
    var element = new OpenXmlElementType();
    UpdateOpenXmlElement<OpenXmlEnumType, ModelEnumType>(element, value);
    return element;
  }

  /// <summary>
  /// Updates an OpenXml OpenXmlElementType containing the OpenXmlEnumType "Val" property from the specified ModelEnumType value. 
  /// </summary>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <typeparam name="ModelEnumType"></typeparam>
  /// <param name="element"></param>
  /// <param name="value"></param>
  /// <exception cref="InvalidOperationException"></exception>
  public static void UpdateOpenXmlElement<OpenXmlEnumType, ModelEnumType>(this DX.OpenXmlLeafElement element, ModelEnumType value)
  where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  where ModelEnumType : struct, IConvertible
  {
    var n = (int)System.Convert.ChangeType(value, typeof(int));
    var val = (OpenXmlEnumType)Enum.ToObject(typeof(OpenXmlEnumType), n);
    var valueProperty = element.GetType().GetProperty("Type") ??
      element.GetType().GetProperty("Value") ?? element.GetType().GetProperty("Val");
    //if (valueProperty == null)
    //  valueProperty = element.GetType().GetProperties().FirstOrDefault(item => item.PropertyType == typeof(OpenXmlEnumType));
    if (valueProperty == null /*|| valueProperty.PropertyType != typeof(OpenXmlEnumType)*/)
      throw new InvalidOperationException($"Type \"{element.GetType()}\" does not have a property of \"{typeof(OpenXmlEnumType)}\" type");
    valueProperty.SetValue(element, new DocumentFormat.OpenXml.EnumValue<OpenXmlEnumType>(val));
  }

  #region EnumType get/set methods
  /// <summary>
  /// Gets an OpenXmlEnumType from the "Val" property of the OpenXmlElementType in the OpenXmlCompositeElement.
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static EnumType? GetEnumVal<EnumType, OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where EnumType : struct
  where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
        var val = valProperty.GetValue(_element);
        if (val != null)
        {
          var valType = val.GetType();
          Debug.Assert(valType.Name.StartsWith("EnumValue`1"), $"\"Val\" property in {typeof(OpenXmlElementType)} must be EnumValue<>");
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value != null)
          {
            var openXmlEnumType = value.GetType();
            if (openXmlEnumType != typeof(EnumType))
            {
              if (value is IConvertible)
              {
                var n = (int)System.Convert.ChangeType(value, typeof(int));
                value = Enum.ToObject(typeof(EnumType), n);
              }
              else
              {
                var property = openXmlEnumType.GetProperties(BindingFlags.Static | BindingFlags.Public).FirstOrDefault(prop => value.Equals(prop.GetValue(null)));
                if (property != null)
                {
                  var s = property.Name;
                  var k = s.IndexOf(' ');
                  if (k > 0)
                    s = s.Substring(0, k);
                  var newValue = Enum.Parse(typeof(EnumType), s, true);
                  return (EnumType)newValue;
                }
              }
            }
            return (EnumType)value;
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets an OpenXmlEnumType with the "Val" property of the OpenXmlElementType in the OpenXmlCompositeElement.
  /// </summary>
  /// <typeparam name="EnumType">Type of enum value</typeparam>
  /// <typeparam name="ElementType">Type of OpenXmlElement to set value</typeparam>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <param name="openXmlElement">OpenXmlElement to set</param>
  /// <param name="value">value to set</param>
  public static void SetEnumVal<EnumType, OpenXmlEnumType, ElementType>(this DX.OpenXmlCompositeElement openXmlElement, EnumType? value) where EnumType : struct
    where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
    where ElementType : DX.OpenXmlLeafElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element == null)
      {
        var constructor = typeof(ElementType).GetConstructor(Type.EmptyTypes);
        Debug.Assert(constructor != null, $"Type {typeof(ElementType)} must have constructor with no parameters");
        _element = (ElementType)constructor.Invoke(Array.Empty<object>());
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(ElementType).GetProperty("Val");
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
      var valType = valProperty.PropertyType;
      Debug.Assert(valType.Name.StartsWith("EnumValue`1"), $"\"Val\" property in {typeof(ElementType)} must be EnumValue<>");
      var valueType = valType.GetGenericArguments()[0];
      var newValue = EnumValueUtils.EnumTypeToEnumValue<EnumType, OpenXmlEnumType>(value.Value);
      valProperty.SetValue(_element, newValue);
    }
    else
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  /// <summary>
  /// Gets an OpenXmlEnumType value from the specified OpenXml EnumValue&lt;OpenXmlEnumType&gt; parameter.
  /// </summary>
  /// <typeparam name="OpenXmlEnumType">Expected result type</typeparam>
  /// <param name="element">OpenXmlElement element to get value</param>
  /// <returns></returns>
  public static OpenXmlEnumType? GetValue<OpenXmlEnumType>(this DX.EnumValue<OpenXmlEnumType>? element)
 where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    if (element == null) return null;
    object value = element.Value;
    return (OpenXmlEnumType?)value;
  }

  /// <summary>
  /// Gets an enum type value from the specified OpenXml EnumValue&lt;OpenXmlEnumType&gt; parameter.
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <param name="element"></param>
  /// <returns></returns>
  public static EnumType? GetValue<EnumType, OpenXmlEnumType>(this DX.EnumValue<OpenXmlEnumType>? element)
    where EnumType : struct
    where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    if (element == null) return null;
    object value = element.Value;
    if (typeof(OpenXmlEnumType) != typeof(EnumType))
    {
      var n = (int)System.Convert.ChangeType(value, typeof(int));
      value = Enum.ToObject(typeof(EnumType), n);
    }
    return (EnumType)value;
  }

  /// <summary>
  /// Creates an instance of the specified OpenXml EnumValue&lt;OpenXmlEnumType&gt; type parameter
  /// and sets an enum type value to this instance.  
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  public static DX.EnumValue<OpenXmlEnumType>? SetValue<EnumType, OpenXmlEnumType>(this EnumType? value) where EnumType : struct
  where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    if (value == null)
      return null;
    object? newValue;
    if (typeof(OpenXmlEnumType) != typeof(EnumType))
    {
      var n = (int)System.Convert.ChangeType(value, typeof(int));
      newValue = Enum.ToObject(typeof(OpenXmlEnumType), n);
    }
    else
      newValue = value;
    return new DX.EnumValue<OpenXmlEnumType>((OpenXmlEnumType)newValue);
  }

  #endregion


}