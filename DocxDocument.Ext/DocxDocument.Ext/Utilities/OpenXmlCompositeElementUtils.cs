namespace DocumentModel;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlCompositeElement object.
/// </summary>
public static class OpenXmlCompositeElementUtils
{
  #region Twips get/set methods

  /// <summary>
  /// Gets a Twips value from the specified OpenXmlCompositeElement. 
  /// The value is specified in the child OpenXmlElementType element in the "Val" property.
  /// This child element may be Word TwipsMeasureType or Math TwipsMeasureType
  /// or Word NonNegativeShortType.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  /// <exception cref="InvalidDataException"></exception>
  public static Twips? GetTwipsVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
      {
        if (_element is DXW.TwipsMeasureType twipsMeasure)
        {
          var str = twipsMeasure.Val?.Value;
          if (str != null)
            return new Twips(str);
        }
        else
        if (_element is DXM.TwipsMeasureType twipsMeasureM)
        {
          var val = twipsMeasureM.Val?.Value;
          if (val != null)
            return new Twips((uint)val);
        }
        else
        if (_element is DXW.NonNegativeShortType nonNegativeShort)
        {
          var n = nonNegativeShort.Val?.Value;
          if (n != null)
            return new Twips((short)n);
        }

        else
          throw new InvalidDataException($"Unsupported twips conversion from type {_element.GetType()}");
      }
    }
    return null;
  }

  /// <summary>
  /// Sets the specified Twips value to the specified OpenXmlCompositeElement. 
  /// The value will be represented by the child OpenXmlElementType element with the "Val" property.
  /// This child element may be Word TwipsMeasureType or Math TwipsMeasureType
  /// or Word NonNegativeShortType.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  /// <exception cref="InvalidDataException"></exception>
  public static void SetTwipsVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, Twips? value)
    where OpenXmlElementType : DX.OpenXmlLeafElement, new()
  {
    if (value is not null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element == null)
      {
        _element = new OpenXmlElementType();
        openXmlElement.AppendChild(_element);
      }
      if (_element is DXW.TwipsMeasureType twipsMeasure)
        twipsMeasure.Val = (string)value;
      else
      if (_element is DXM.TwipsMeasureType twipsMeasureM)
        twipsMeasureM.Val = new DX.UInt32Value((uint)value);
      else
      if (_element is DXW.NonNegativeShortType nonNegativeShort)
        nonNegativeShort.Val = (short)value;

      else
        throw new InvalidDataException($"Unsupported twips conversion to type {_element.GetType()}");
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  #endregion

  #region Object get/set methods
  /// <summary>
  /// Gets an instance of the specified ObjectType from the specified OpenXmlCompositeElement.
  /// The value is represented by the child OpenXmlElementType element.
  /// ObjectType must have an constructor with an OpenXmlElement parameter.
  /// </summary>
  /// <typeparam name="ObjectType"></typeparam>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static ObjectType? GetObject<ObjectType, OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement)
    where ObjectType : class
    where OpenXmlElementType : DX.OpenXmlElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
      {
        var constructor = typeof(ObjectType).GetConstructor(new Type[] { typeof(DX.OpenXmlElement) });
        Debug.Assert(constructor != null, $"Type {typeof(ObjectType)} must have constructor with OpenXmlElement parameter");
        return (ObjectType)constructor.Invoke(new object[] { _element });
      }
    }
    return null;
  }

  /// <summary>
  /// Sets an instance of the specified ObjectType to the specified OpenXmlCompositeElement.
  /// The value is represented by the child OpenXmlElementType element.
  /// ObjectType must implement the IOpenXmlElementMappedObject interface. 
  /// If a child of the OpenXmlElementType already exists, then it is removed.
  /// </summary>
  /// <typeparam name="ObjectType"></typeparam>
  /// <typeparam name="OpenXmlElelemtnType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetObject<ObjectType, OpenXmlElelemtnType>(this DX.OpenXmlCompositeElement openXmlElement, ObjectType? value)
    where ObjectType : class, IOpenXmlElementMappedObject
    where OpenXmlElelemtnType : DX.OpenXmlElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElelemtnType>().FirstOrDefault();
      if (_element != null)
      {
        var _newElement = value.GetElement<OpenXmlElelemtnType>();
        if (_element != _newElement)
        {
          _element.Remove();
          openXmlElement.AppendChild(_newElement);
        }
      }
      else
        openXmlElement.AppendChild(value.GetElement<OpenXmlElelemtnType>());
    }
    else
    {
      var element = openXmlElement.Elements<OpenXmlElelemtnType>().FirstOrDefault();
      if (element != null)
        element.Remove();
    }
  }

  #endregion

  #region EnumType get/set methods
  /// <summary>
  /// Gets an enum value of the specified EnumType from the specified OpenXmlCompositeElement.
  /// The value is specified in the child OpenXmlElementType element in the "Val" property
  /// which must be of OpenXml EnumValue type.
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
            var valueType = value.GetType();
            if (valueType != typeof(EnumType))
            {
              var n = (int)Convert.ChangeType(value, typeof(int));
              value = Enum.ToObject(typeof(EnumType), n);
            }
            return (EnumType)value;
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets the specified enum value to the specified OpenXmlCompositeElement. 
  /// The value is set as the child OpenXmlElementType element to the "Val" property,
  /// which will be of OpenXml EnumValue type.
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="ElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetEnumVal<EnumType, ElementType>(this DX.OpenXmlCompositeElement openXmlElement, EnumType? value) where EnumType : struct
  where ElementType : DX.OpenXmlLeafElement
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
      var valProperty = typeof(ElementType).GetProperty("Val");
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
      var valType = valProperty.PropertyType;
      Debug.Assert(valType.Name.StartsWith("EnumValue`1"), $"\"Val\" property in {typeof(ElementType)} must be EnumValue<>");
      var valueType = valType.GetGenericArguments()[0];
      object? newValue;
      if (valueType != typeof(EnumType))
      {
        var n = (int)Convert.ChangeType(value, typeof(int));
        newValue = Enum.ToObject(valueType, n);
      }
      else
        newValue = value;
      var enumValuesType = typeof(DX.EnumValue<>).MakeGenericType(valueType);
      newValue = enumValuesType.GetConstructor(new Type[] { valueType })?.Invoke(new object[] { newValue });
      valProperty.SetValue(_element, newValue);
    }
    else
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  #endregion

  #region Boolean get/set methods

  /// <summary>
  /// Gets a boolean value from the specified OpenXmlCompositeElement. 
  /// The value is specified in the child OpenXmlElementType element in the "Val" property.
  /// This child element may be Word OnOffType or Office13 Word OnOffType
  /// or Math OnOffType.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  /// <exception cref="InvalidDataException"></exception>
  public static bool? GetBoolVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
      {
        if (_element is DXW.OnOffType onOffType)
        {
          if (onOffType.Val?.HasValue == true)
            return onOffType.Val.Value;
          return true;
        }
        else
        if (_element is DXW13.OnOffType onOffType13)
        {
          if (onOffType13.Val?.HasValue == true)
            return onOffType13.Val.Value;
          return true;
        }
        else if (_element is DXM.OnOffType onOffTypeM)
        {
          if (onOffTypeM.Val?.HasValue == true)
          {
            if (
              onOffTypeM.Val.Value == DXM.BooleanValues.One ||
              onOffTypeM.Val.Value == DXM.BooleanValues.True ||
              onOffTypeM.Val.Value == DXM.BooleanValues.On)
              return true;
            else
            if (
              onOffTypeM.Val.Value == DXM.BooleanValues.Zero ||
              onOffTypeM.Val.Value == DXM.BooleanValues.False ||
              onOffTypeM.Val.Value == DXM.BooleanValues.Off)
              return false;
            else throw new InvalidDataException($"Invalid Math.OnOffType Val property");
          }
          return true;
        }
        else
          throw new InvalidDataException($"Unsupported boolean conversion from type {_element.GetType()}");
      }
    }
    return null;
  }

  /// <summary>
  /// Sets the specified boolean value to the specified OpenXmlCompositeElement. 
  /// The value is set as the child OpenXmlElementType element to the "Val" property.
  /// This child element may be Word OnOffType or Office13 Word OnOffType
  /// or Math OnOffType.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  /// <exception cref="InvalidDataException"></exception>
  public static void SetBoolVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, bool? value) where OpenXmlElementType : DX.OpenXmlLeafElement, new()
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element == null)
      {
        _element = new OpenXmlElementType();
        openXmlElement.AppendChild(_element);
      }
      if (_element is DXW.OnOffType onOffType)
        onOffType.Val = value;
      else
      if (_element is DXW13.OnOffType onOffType13)
        onOffType13.Val = value;
      else
      if (_element is DXM.OnOffType onOffTypeM)
      {
        if (value == true)
          onOffTypeM.Val = DXM.BooleanValues.One;
        else
        if (value == false)
          onOffTypeM.Val = DXM.BooleanValues.Zero;
      }
        else
          throw new InvalidDataException($"Unsupported boolean conversion to type {_element.GetType()}");
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  /// <summary>
  /// Gets a boolean value from the specified OpenXmlCompositeElement. 
  /// The result is true if the specified OpenXmlElementType element exists.
  /// Otherwise the result is false.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static bool? GetTrueIfExists<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DXW.EmptyType
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      return _element != null;
    }
    return null;
  }

  /// <summary>
  /// Sets ths specified boolean value to the specified OpenXmlCompositeElement. 
  /// if the specified boolean value is true, then a child OpenXMlElementType element is appended.
  /// Otherwise and existing child of the specified OpenXMlElementType is removed.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetExistsIfTrue<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, bool? value) where OpenXmlElementType : DXW.EmptyType, new()
  {
    if (value != null)
    {
      if (value == true)
      {
        if (openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault() == null)
          openXmlElement.AppendChild(new OpenXmlElementType());
      }
      else
      {
        var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
        if (_element != null)
          _element.Remove();
      }
    }
  }
  #endregion

  #region HexInt get/set methods

  /// <summary>
  /// Gets a HexInt value from the specified OpenXmlCompositeElement. 
  /// The value is specified in the child OpenXmlElementType element in the "Val" property.
  /// This child element may be Word LongHexNumberType or other element with proper hexadecimal value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static HexInt? GetHexIntVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element is DXW.LongHexNumberType longHexNumberType)
      {
        if (longHexNumberType.Val?.Value != null)
          return new HexInt(longHexNumberType.Val.Value!);
      }
      else
      if (_element != null)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
        var val = valProperty.GetValue(_element);
        if (val != null)
        {
          var valType = val.GetType();
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value is string str)
          {
            return new HexInt(str);
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets a HexInt value to the specified OpenXmlCompositeElement. 
  /// The value will be represented by the child OpenXmlElementType with the "Val" property.
  /// This child element may be Word LongHexNumberType or other element with proper hexadecimal value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  /// <exception cref="InvalidOperationException"></exception>
  public static void SetHexIntVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, HexInt? value) where OpenXmlElementType : DX.OpenXmlElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element == null)
      {
        var constructor = typeof(OpenXmlElementType).GetConstructor(new Type[0]);
        Debug.Assert(constructor != null, $"Type {typeof(OpenXmlElementType)} must have constructor with no parameters");
        _element = (OpenXmlElementType)constructor.Invoke(new object[0]);
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
      var valType = valProperty.PropertyType;
      if (valType == typeof(DX.HexBinaryValue))
        valProperty.SetValue(_element, new DX.HexBinaryValue(value.ToString()));
      else
      if (valType == typeof(DX.StringValue))
        valProperty.SetValue(_element, new DX.StringValue(value.ToString()));
      else
        throw new InvalidOperationException($"\"Value\" property of type {valType} unsupported");
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  #endregion


  #region Guid get/set methods
  /// <summary>
  /// Gets a Guid value from the specified OpenXmlCompositeElement. 
  /// The value is specified in the child OpenXmlElementType element in the "Val" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static Guid? GetGuidVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DX.OpenXmlLeafElement
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
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value is string str)
          {
            return new Guid(str);
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets a Guid value to the specified OpenXmlCompositeElement. 
  /// The value will be represented in the child OpenXmlElementType element in the "Val" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  /// <exception cref="InvalidOperationException"></exception>
  public static void SetGuidVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, Guid? value) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element == null)
      {
        var constructor = typeof(OpenXmlElementType).GetConstructor(new Type[0]);
        Debug.Assert(constructor != null, $"Type {typeof(OpenXmlElementType)} must have constructor with no parameters");
        _element = (OpenXmlElementType)constructor.Invoke(new object[0]);
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
      var valType = valProperty.PropertyType;
      if (valType == typeof(DX.StringValue))
        valProperty.SetValue(_element, new DX.StringValue(value.ToString()));
      else
        throw new InvalidOperationException($"\"Value\" property of type {valType} unsupported");
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  #endregion

  #region String get/set methods
  /// <summary>
  /// Gets a string value from the specified OpenXmlCompositeElement. 
  /// The value is specified in the child OpenXmlElementType element in the "Val" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static string? GetStringVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DX.OpenXmlLeafElement
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
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value is not null)
          {
            if (value is string str)
              return str;
            return value.ToString();
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets a string value to the specified OpenXmlCompositeElement. 
  /// The value will be represented in the child OpenXmlElementType element in the "Val" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetStringVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, string? value) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element == null)
      {
        var constructor = typeof(OpenXmlElementType).GetConstructor(new Type[0]);
        Debug.Assert(constructor != null, $"Type {typeof(OpenXmlElementType)} must have constructor with no parameters");
        _element = (OpenXmlElementType)constructor.Invoke(new object[0]);
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
      if (valProperty == null)
        valProperty = typeof(OpenXmlElementType).GetProperty("Id");
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
      var valType = valProperty.PropertyType;
      var valueProperty = valType.GetProperty("Value");
      Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
      valProperty.SetValue(_element, new DX.StringValue(value));
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  /// <summary>
  /// Gets a string value from the specified OpenXmlCompositeElement. 
  /// The value is specified in the child OpenXmlElementType in the "Id" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static string? GetStringId<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperty("Id");
        Debug.Assert(valProperty != null, $"\"Id\" property in {typeof(OpenXmlElementType)} not found");
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
              return str;
            return value.ToString();
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets a string value to the specified OpenXmlCompositeElement. 
  /// The value will be represented in the child OpenXmlElementType element in the "Id" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetStringId<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, string? value) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element == null)
      {
        var constructor = typeof(OpenXmlElementType).GetConstructor(new Type[0]);
        Debug.Assert(constructor != null, $"Type {typeof(OpenXmlElementType)} must have constructor with no parameters");
        _element = (OpenXmlElementType)constructor.Invoke(new object[0]);
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(OpenXmlElementType).GetProperty("Id");
      Debug.Assert(valProperty != null, $"\"Id\" property in {typeof(OpenXmlElementType)} not found");
      var valType = valProperty.PropertyType;
      var valueProperty = valType.GetProperty("Value");
      Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
      valProperty.SetValue(_element, value);
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  #endregion

  #region Reference get/set methods
  /// <summary>
  /// Gets a Reference value from the specified OpenXmlCompositeElement. 
  /// The value is specified in the child OpenXmlElementType element in the "Id" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static Reference? GetRefId<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperty("Id");
        Debug.Assert(valProperty != null, $"\"Id\" property in {typeof(OpenXmlElementType)} not found");
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

  /// <summary>
  /// Sets a Reference value to the specified OpenXmlCompositeElement. 
  /// The value will be represented in the child OpenXmlElementType element in the "Id" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  public static void SetRefId<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, Reference? value) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element == null)
      {
        var constructor = typeof(OpenXmlElementType).GetConstructor(new Type[0]);
        Debug.Assert(constructor != null, $"Type {typeof(OpenXmlElementType)} must have constructor with no parameters");
        _element = (OpenXmlElementType)constructor.Invoke(new object[0]);
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(OpenXmlElementType).GetProperty("Id");
      Debug.Assert(valProperty != null, $"\"Id\" property in {typeof(OpenXmlElementType)} not found");
      var valType = valProperty.PropertyType;
      var valueProperty = valType.GetProperty("Value");
      Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
      valProperty.SetValue(_element, new DX.StringValue(value.ToString()));
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  #endregion

  #region Int get/set methods

  /// <summary>
  /// Gets an integer value from the specified OpenXmlCompositeElement. 
  /// The value is specified in the child OpenXmlElementType element in the "Val" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static int? GetIntVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DX.OpenXmlLeafElement
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
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value != null)
          {
            if (value is Int32 n)
              return n;
            n = Convert.ToInt32(value);
            return n;
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets an integer value to the specified OpenXmlCompositeElement. 
  /// The value will be represented in the child OpenXmlElementType element in the "Val" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  /// <exception cref="InvalidOperationException"></exception>
  public static void SetIntVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, int? value) where OpenXmlElementType : DX.OpenXmlLeafElement, new()
  {
    if (value is not null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element == null)
      {
        _element = new OpenXmlElementType();
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
      Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(OpenXmlElementType)} not found");
      var valType = valProperty.PropertyType;
      if (valType == typeof(DX.Int32Value))
        valProperty.SetValue(_element, new DX.Int32Value(value));
      else
      if (valType == typeof(DX.UInt16Value))
        valProperty.SetValue(_element, new DX.UInt16Value((UInt16)value));
      else
      if (valType == typeof(DX.UInt32Value))
        valProperty.SetValue(_element, new DX.UInt32Value((UInt32)value));
      else
      if (valType == typeof(DX.StringValue))
        valProperty.SetValue(_element, new DX.StringValue(value.ToString()));
      else
      if (valType == typeof(DX.Int16Value))
        valProperty.SetValue(_element, new DX.Int16Value((Int16)value));
      else
        throw new InvalidOperationException($"Can't SetIntVal for valType={valType}");
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  /// <summary>
  /// Gets an integer value from the specified OpenXmlCompositeElement. 
  /// The value is specified in the child OpenXmlLeafElement element in the "Id" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <returns></returns>
  public static int? GetIntId<OpenXmlElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperty("Id");
        Debug.Assert(valProperty != null, $"\"Id\" property in {typeof(OpenXmlElementType)} not found");
        var val = valProperty.GetValue(_element);
        if (val != null)
        {
          var valType = val.GetType();
          var valueProperty = valType.GetProperty("Value");
          Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
          var value = valueProperty.GetValue(val);
          if (value != null)
          {
            if (value is Int32 n)
              return n;
            n = Convert.ToInt32(value);
            return n;
          }
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Sets an integer value to the specified OpenXmlCompositeElement. 
  /// The value will be represented in the child OpenXmlElementType element in the "Id" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <param name="openXmlElement"></param>
  /// <param name="value"></param>
  /// <exception cref="InvalidCastException"></exception>
  public static void SetIntId<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, int? value) where OpenXmlElementType : DX.OpenXmlLeafElement, new()
  {
    if (value is not null)
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element == null)
      {
        _element = new OpenXmlElementType();
        openXmlElement.AppendChild(_element);
      }
      var valProperty = typeof(OpenXmlElementType).GetProperty("Id");
      Debug.Assert(valProperty != null, $"\"Id\" property in {typeof(OpenXmlElementType)} not found");
      var valType = valProperty.PropertyType;
      if (valType == typeof(DX.Int32Value))
        valProperty.SetValue(_element, new DX.Int32Value(value));
      else
      if (valType == typeof(DX.IntegerValue))
        valProperty.SetValue(_element, new DX.IntegerValue(value));
      else
        throw new InvalidCastException($"Unsupported typecast operation from {value.GetType()} to int");
    }
    else
    {
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  #endregion

  /// <summary>
  /// Helper method that appends a child of OpenXmlElement to the OpenXmlCompositeElement.
  /// If the added element is a child of any other parent, then it must be removed from this parent before adding.
  /// </summary>
  /// <param name="openXmlElement"></param>
  /// <param name="childElement"></param>
  public static void AddChildElement(this DX.OpenXmlCompositeElement openXmlElement, DX.OpenXmlElement childElement)
  {
    if (childElement.Parent != null)
      childElement.Remove();
    openXmlElement.AppendChild(childElement);
  }

}
