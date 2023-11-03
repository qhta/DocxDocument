namespace DocumentModel;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlCompositeElement object.
/// </summary>
public static class OpenXmlCompositeElementUtils
{
  #region Twips get/set methods
  public static Twips? GetTwipsVal<ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        if (_element is DXW.TwipsMeasureType twipsMeasure)
        {
          var str = twipsMeasure.Val?.Value;
          if (str != null)
            return new Twips(str);
        }
        else
        if (_element is DXW.NonNegativeShortType nonNegativeShort)
        {
          var n = nonNegativeShort.Val?.Value;
          if (n != null)
            return new Twips((short)n);
        }
        else
        if (_element is DXM.TwipsMeasureType twipsMeasureM)
        {
          var val = twipsMeasureM.Val?.Value;
          if (val != null)
            return new Twips((uint)val);
        }
        else
          throw new InvalidDataException($"Unsupported twips conversion from type {_element.GetType()}");
      }
    }
    return null;
  }

  public static void SetTwipsVal<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, Twips? value) where ElementType : DX.OpenXmlLeafElement, new()
  {
    if (value is not null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element == null)
      {
        _element = new ElementType();
        openXmlElement.AppendChild(_element);
      }
      if (_element is DXW.TwipsMeasureType twipsMeasure)
        twipsMeasure.Val = (string)value;
      else
      if (_element is DXW.NonNegativeShortType nonNegativeShort)
        nonNegativeShort.Val = (short)value;
      else
      if (_element is DXM.TwipsMeasureType twipsMeasureM)
        twipsMeasureM.Val = new DX.UInt32Value((uint)value);
      else
        throw new InvalidDataException($"Unsupported twips conversion to type {_element.GetType()}");
    }
    else
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  #endregion

  #region Object get/set methods
  public static ObjectType? GetObject<ObjectType, ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ObjectType : class
    where ElementType : DX.OpenXmlElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var constructor = typeof(ObjectType).GetConstructor(new Type[] { typeof(DX.OpenXmlElement) });
        Debug.Assert(constructor != null, $"Type {typeof(ObjectType)} must have constructor with OpenXmlElement parameter");
        return (ObjectType)constructor.Invoke(new object[] { _element });
      }
    }
    return null;
  }

  public static void SetObject<ObjectType, ElementType>(this DX.OpenXmlCompositeElement openXmlElement, ObjectType? value) where ObjectType : class, IOpenXmlElementMappedObject
  where ElementType : DX.OpenXmlElement
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var _newElement = value.GetElement<ElementType>();
        if (_element != _newElement)
        {
          _element.Remove();
          openXmlElement.AppendChild(_newElement);
        }
      }
      else
        openXmlElement.AppendChild(value.GetElement<ElementType>());
    }
    else
    {
      var setting = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (setting != null)
        setting.Remove();
    }
  }
  #endregion

  #region EnumType get/set methods
  public static EnumType? GetEnumVal<EnumType, ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where EnumType : struct
  where ElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(ElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
        var val = valProperty.GetValue(_element);
        if (val != null)
        {
          var valType = val.GetType();
          Debug.Assert(valType.Name.StartsWith("EnumValue`1"), $"\"Val\" property in {typeof(ElementType)} must be EnumValue<>");
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
      object newValue;
      if (valueType != typeof(EnumType))
      {
        var n = (int)Convert.ChangeType(value, typeof(int));
        newValue = Enum.ToObject(valueType, n);
      }
      else
        newValue = value;
      valProperty.SetValue(_element, newValue);
    }
    else
    {
      var setting = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (setting != null)
        setting.Remove();
    }
  }
  #endregion

  #region Boolean get/set methods
  public static Boolean? GetBooleanVal<ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
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
        else
        if (_element is DXM.OnOffType onOffTypeM)
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
      }
    }
    return null;
  }

  public static void SetBooleanVal<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, Boolean? value) where ElementType : DX.OpenXmlLeafElement, new()
  {
    if (value != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element == null)
      {
        _element = new ElementType();
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
    }
    else
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  public static Boolean? GetTrueIfExists<ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ElementType : DXW.EmptyType
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      return _element != null;
    }
    return null;
  }

  public static void SetExistsIfTrue<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, Boolean? value) where ElementType : DXW.EmptyType, new()
  {
    if (value != null)
    {
      if (value == true)
      {
        if (openXmlElement.Elements<ElementType>().FirstOrDefault() == null)
          openXmlElement.AppendChild(new ElementType());
      }
      else
      {
        var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
        if (_element != null)
          _element.Remove();
      }
    }
  }
  #endregion

  #region HexInt get/set methods
  public static HexInt? GetHexIntVal<ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element is DXW.LongHexNumberType longHexNumberType)
      {
        if (longHexNumberType.Val?.Value != null)
          return new HexInt(longHexNumberType.Val.Value!);
      }
      else
      if (_element != null)
      {
        var valProperty = typeof(ElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
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

  public static void SetHexIntVal<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, HexInt? value) where ElementType : DX.OpenXmlElement
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
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  #endregion


  #region Guid get/set methods
  public static Guid? GetGuidVal<ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(ElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
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

  public static void SetGuidVal<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, Guid? value) where ElementType : DX.OpenXmlLeafElement
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
      if (valType == typeof(DX.StringValue))
        valProperty.SetValue(_element, new DX.StringValue(value.ToString()));
      else
        throw new InvalidOperationException($"\"Value\" property of type {valType} unsupported");
    }
    else
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  #endregion

  #region String get/set methods
  public static String? GetStringVal<ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(ElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
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

  public static void SetStringVal<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, String? value) where ElementType : DX.OpenXmlLeafElement
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
      var valueProperty = valType.GetProperty("Value");
      Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
      valProperty.SetValue(_element, value);
    }
    else
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  
    public static String? GetStringId<ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ElementType : DX.OpenXmlLeafElement
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
              return str;
            return value.ToString();
          }
        }
      }
    }
    return null;
  }

  public static void SetStringId<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, String? value) where ElementType : DX.OpenXmlLeafElement
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
      valProperty.SetValue(_element, value);
    }
    else
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }
  #endregion

  #region Int get/set methods
  public static Int32? GetInt32Val<ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ElementType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
      {
        var valProperty = typeof(ElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
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
            throw new InvalidCastException($"Unsupported typecast operation from {value.GetType()} to int");
          }
        }
      }
    }
    return null;
  }

  public static void SetInt32Val<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, Int32? value) where ElementType : DX.OpenXmlLeafElement, new()
  {
    if (value is not null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element == null)
      {
        _element = new ElementType();
        openXmlElement.AppendChild(_element);
      }
        var valProperty = typeof(ElementType).GetProperty("Val");
        Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
        var valType = valProperty.PropertyType;
        if (valType == typeof (DX.Int32Value))
          valProperty.SetValue(_element, new DX.Int32Value(value));
        else
          throw new InvalidCastException($"Unsupported typecast operation from {value.GetType()} to int");
    }
    else
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  public static Int32? GetInt32Id<ElementType>(this DX.OpenXmlCompositeElement? openXmlElement) where ElementType : DX.OpenXmlLeafElement
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
          if (value != null)
          {
            if (value is Int32 n)
              return n;
            throw new InvalidCastException($"Unsupported typecast operation from {value.GetType()} to int");
          }
        }
      }
    }
    return null;
  }

  public static void SetInt32Id<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, Int32? value) where ElementType : DX.OpenXmlLeafElement, new()
  {
    if (value is not null)
    {
      var _element = openXmlElement.Elements<ElementType>().FirstOrDefault();
      if (_element == null)
      {
        _element = new ElementType();
        openXmlElement.AppendChild(_element);
      }
        var valProperty = typeof(ElementType).GetProperty("Id");
        Debug.Assert(valProperty != null, $"\"Id\" property in {typeof(ElementType)} not found");
        var valType = valProperty.PropertyType;
        if (valType == typeof (DX.Int32Value))
          valProperty.SetValue(_element, new DX.Int32Value(value));
        else
          throw new InvalidCastException($"Unsupported typecast operation from {value.GetType()} to int");
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
