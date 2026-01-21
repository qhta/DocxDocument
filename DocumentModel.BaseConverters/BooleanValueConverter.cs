namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for boolean values in Open XML.
/// </summary>
public static class BooleanValueConverter
{
  #region OnOffValue conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified OnOffValue element.
  /// </summary>
  /// <param name="element">The OnOffValue element to check.</param>
  /// <returns>A boolean representing the value, or null if the element is null.</returns>
  public static Boolean? GetValue(this OnOffValue? element)
  {
    return element?.Value;
  }

  /// <summary>
  /// Creates an OnOffValue using specified string representations for false and true.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="falseString">The string representation for false (default is "0").</param>
  /// <param name="trueString">The string representation for true (default is "1").</param>
  /// <returns>A new OnOffValue object, or null if the input value is null.</returns>
  public static OnOffValue? CreateOnOffValue(this Boolean? value, string? falseString = null, string? trueString = null)
  {
    if (value == null) return null;
    if (trueString == null)
    {
      falseString = "0";
      trueString = "1";
    }
    var val = (Boolean)value ? trueString : falseString;
    if (val == null)
      return null;
    return new OnOffValue { InnerText = val };
  }
  #endregion

  #region OnOffOnlyValue conversion.
  /// <summary>
  /// Retrieves a boolean value from the specified OnOffOnlyValues element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyValues element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  public static Boolean? GetValue(this DXW.OnOffOnlyValues? openXmlElement)
  {
    if (openXmlElement == null) return null;
    return openXmlElement == DXW.OnOffOnlyValues.On;
  }

  /// <summary>
  /// Creates an OnOffOnlyValues element from the specified boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>OnOffOnlyValues.On if true, OnOffOnlyValues.Off if false, otherwise null.</returns>
  public static DXW.OnOffOnlyValues? CreateOnOffOnlyValue(this Boolean? value)
  {
    if (value == true) return DXW.OnOffOnlyValues.On;
    if (value == false) return DXW.OnOffOnlyValues.Off;
    return null;
  }
  #endregion

  #region OnOffType conversion.
  /// <summary>
  /// Retrieves a boolean value from the specified OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null, or null if element is null.</returns>
  public static Boolean? GetValue(this DXW.OnOffType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value;
    if (openXmlElement != null) return true;
    return null;
  }


  /// <summary>
  /// Sets an OnOffType value on an OpenXmlCompositeElement using specified string representations.
  /// Adds the element if it doesn't exist and value is true or distinct string provided.
  /// Removes the element if value is false.
  /// </summary>
  /// <param name="openXmlElement">The composite element to modify.</param>
  /// <param name="value">The boolean value to set.</param>
  /// <param name="falseString">The string representation for false (default is "0").</param>
  /// <param name="trueString">The string representation for true (default is "1").</param>
  public static void SetOnOffType<OpenXmlElementType>(this OpenXmlCompositeElement openXmlElement, Boolean? value,
    string? falseString = null, string? trueString = null)
    where OpenXmlElementType : DXW.OnOffType, new()
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<OpenXmlElementType>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value != null)
    {
      if (trueString == null && falseString == null)
      {
        falseString = "0";
        trueString = "1";
      }
      string? valStr = (bool)value ? trueString : falseString;
      if (valStr != null || value == true)
      {
        var itemElement = new OpenXmlElementType();
        if (valStr != null)
          itemElement.SetAttribute(new OpenXmlAttribute("val", openXmlElement.NamespaceUri, valStr));
        openXmlElement.AppendChild(itemElement);
      }
    }
  }

  #endregion

  #region Math OnOffType conversion.
  /// <summary>
  /// Retrieves a boolean value from the specified Math OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The Math OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null, or null if element is null.</returns>
  public static Boolean? GetValue(DXM.OnOffType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return GetValue(openXmlElement.Val.Value);
    if (openXmlElement != null) return true;
    return null;
  }

  /// <summary>
  /// Sets a Math OnOffType value on an OpenXmlCompositeElement.
  /// Adds the element if value is true, removes it if value is false.
  /// </summary>
  /// <typeparam name="ElementType">The specific Math OnOffType.</typeparam>
  /// <param name="openXmlElement">The composite element to modify.</param>
  /// <param name="value">The boolean value to set.</param>
  public static void SetMathOnOffType<ElementType>(this OpenXmlCompositeElement openXmlElement, Boolean? value)
    where ElementType : DXM.OnOffType, new()
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<ElementType>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new ElementType();
      openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region OnOffOnlyType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified OnOffOnlyType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyType element to check.</param>
  /// <returns>True if the value is On, false if the value is Off, or true if the element exists without a value.</returns>
  public static Boolean GetValue(this DXW.OnOffOnlyType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value == DXW.OnOffOnlyValues.On;
    return openXmlElement != null;
  }

  /// <summary>
  /// Sets an OnOffOnlyType value on an OpenXmlCompositeElement.
  /// Adds the element if value is true, removes it if value is false.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The specific OnOffOnlyType.</typeparam>
  /// <param name="openXmlElement">The composite element to modify.</param>
  /// <param name="value">The boolean value to set.</param>
  public static void SetOnOffOnlyType<OpenXmlElementType>(this OpenXmlCompositeElement openXmlElement, Boolean? value)
    where OpenXmlElementType : DXW.OnOffOnlyType, new()
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<OpenXmlElementType>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = openXmlElement.GetFirstChild<OpenXmlElementType>();
      if (itemElement == null)
        openXmlElement.AppendChild(new OpenXmlElementType());
    }
  }
  #endregion

  #region Office2010 Word OnOffValues conversion.
  /// <summary>
  /// Retrieves a boolean value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  public static Boolean? GetValue(this DX.EnumValue<DXO10W.OnOffValues>? openXmlElement)
  {
    if (openXmlElement?.Value != null)
    {
      var value = openXmlElement.Value;
      if (value == DXO10W.OnOffValues.True
        || value == DXO10W.OnOffValues.One)
        return true;
      if (value == DXO10W.OnOffValues.False
        || value == DXO10W.OnOffValues.Zero)
        return false;
    }
    return null;
  }


  //public static void UpdateOpenXmlElement<ElementType>(ElementType openXmlElement, Boolean value)
  //  where ElementType : DX.OpenXmlElement, new()
  //{
  //  var valueProp = typeof(ElementType).GetProperty("Value");
  //  if (valueProp != null)
  //    valueProp.SetValue(openXmlElement, value == true);
  //  else
  //    throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(ElementType)}");
  //}

  //public static ElementType CreateOpenXmlElement<ElementType>(Boolean value)
  //where ElementType : DX.OpenXmlElement, new()
  //{
  //  var openXmlElement = new ElementType();
  //  var valueProp = typeof(ElementType).GetProperty("Value");
  //  if (valueProp != null)
  //    valueProp.SetValue(openXmlElement, value == true);
  //  else
  //    throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(ElementType)}");
  //  return openXmlElement;
  //}
  #endregion

  #region Office2013 Word OnOffType conversion.
  /// <summary>
  /// Retrieves a boolean value from the specified Word 2013 OnOffType.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null, or null if element is null.</returns>
  public static Boolean? GetValue(this DXO13W.OnOffType? openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value;
    if (openXmlElement != null) return true;
    return null;
  }

  /// <summary>
  /// Sets a Word 2013 OnOffType value on an OpenXmlCompositeElement.
  /// Adds the element if value is true, removes it if value is false.
  /// </summary>
  /// <typeparam name="ElementType">The specific OnOffType.</typeparam>
  /// <param name="openXmlElement">The composite element to modify.</param>
  /// <param name="value">The boolean value to set.</param>
  public static void SetO13OnOffType<ElementType>(this OpenXmlCompositeElement openXmlElement, Boolean? value)
    where ElementType : DXO13W.OnOffType, new()
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<ElementType>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new ElementType { Val = value };
        openXmlElement.AppendChild(itemElement);
      }
    }
  }
  #endregion

  #region Math BooleanValues conversion.
  /// <summary>
  /// Retrieves a boolean value from the specified Math BooleanValues enum value.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of BooleanValues to check.</param>
  /// <returns>True for True/On/One, false for False/Off/Zero, or null.</returns>
  public static Boolean? GetValue(this DX.EnumValue<DXM.BooleanValues>? openXmlElement)
  {
    if (openXmlElement?.Value != null)
    {
      var value = openXmlElement.Value;
      if (value == DXM.BooleanValues.True
        || value == DXM.BooleanValues.On
        || value == DXM.BooleanValues.One)
        return true;
      if (value == DXM.BooleanValues.False
        || value == DXM.BooleanValues.Off
        || value == DXM.BooleanValues.Zero)
        return false;
    }
    return null;
  }

  /// <summary>
  /// Updates an OpenXmlElement with the specified OnOffValue.
  /// </summary>
  /// <typeparam name="ElementType">The type of the OpenXmlElement.</typeparam>
  /// <param name="openXmlElement">The element to update.</param>
  /// <param name="value">The OnOffValue to set.</param>
  /// <exception cref="InvalidProgramException">Thrown if the "Value" property is not found on the element type.</exception>
  public static void UpdateOpenXmlElement<ElementType>(this ElementType openXmlElement, OnOffValue value)
    where ElementType : DX.OpenXmlElement, new()
  {
    var valueProp = typeof(ElementType).GetProperty("Value");
    if (valueProp == null)
      throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(ElementType)}");
    else
      valueProp.SetValue(openXmlElement, value == true);
  }

  /// <summary>
  /// Converts a boolean value to the specified OpenXmlElement type.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="openXmlType">The target OpenXmlElement type.</param>
  /// <returns>The converted OpenXmlElement, or null if the conversion failed.</returns>
  /// <exception cref="InvalidOperationException">Thrown if  conversion to the openXmlType is not supported.</exception>
  public static object? CreateOpenXmlElement(bool value, Type openXmlType)
  {
    if (openXmlType == typeof(DX.BooleanValue))
      return new DX.BooleanValue(value);
    if (openXmlType == typeof(DX.EnumValue<DXM.BooleanValues>))
      return new DX.EnumValue<DXM.BooleanValues>(value ? DXM.BooleanValues.True : DXM.BooleanValues.False);
    if (openXmlType == typeof(DX.OnOffValue))
      return DX.OnOffValue.FromBoolean(value);
    if (openXmlType.IsSubclassOf(typeof(DXW.OnOffType)))
    {
      var onOffTypeValue = (DXW.OnOffType)Activator.CreateInstance(openXmlType)!;
      onOffTypeValue.Val = new DX.OnOffValue(value);
      return onOffTypeValue;
    }
    if (openXmlType.IsSubclassOf(typeof(DXW.OnOffOnlyType)))
    {
      var onOffOnlyTypeValue = (DXW.OnOffOnlyType)Activator.CreateInstance(openXmlType)!;
      onOffOnlyTypeValue.Val = value ? DXW.OnOffOnlyValues.On : DXW.OnOffOnlyValues.Off;
      return onOffOnlyTypeValue;
    }

    throw new InvalidOperationException($"Cannot create OpenXmlElement of type {openXmlType} from boolean value.");
  }

  /// <summary>
  /// Retrieves the boolean value represented by the specified Open XML element, if available.  
  /// </summary>
  /// <remarks>This method is intended for use with Open XML SDK types that represent boolean values. If the
  /// element is not one of the supported types, an exception is thrown.</remarks>
  /// <param name="openXmlElement">The Open XML element from which to extract the boolean value. This can be an instance of BooleanValue,
  /// EnumValue&lt;BooleanValues&gt;, OnOffValue, OnOffType, or OnOffOnlyType. Can be null.</param>
  /// <returns>A nullable boolean value representing the value of the specified element, or null if the element is null or does
  /// not contain a value.</returns>
  /// <exception cref="InvalidOperationException">Thrown if the specified element is not a supported type for extracting a boolean value.</exception>
  public static bool? GetBoolValue(this object? openXmlElement)
  {
    var openXmlType = openXmlElement?.GetType();
    if (openXmlElement is DX.BooleanValue booleanValue)
      return booleanValue.Value;
    if (openXmlElement is DX.EnumValue<DXM.BooleanValues> enumValue)
      return enumValue.GetValue();
    if (openXmlElement is DX.OnOffValue onOffValue)
      return onOffValue.GetValue();
    if (openXmlElement is DXW.OnOffType onOffType)
      return onOffType.GetValue();
    if (openXmlElement is DXW.OnOffOnlyType onOffOnlyType)
      return onOffOnlyType.GetValue();
    throw new InvalidOperationException($"Cannot get boolean value from type {openXmlType}");

  }

  /// <summary>
  /// Creates an OpenXmlElement from the specified OnOffValue and sets its "Val" or "Value" property.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the OpenXmlElement to create.</typeparam>
  /// <param name="value">The OnOffValue to set.</param>
  /// <returns>A new instance of the specified OpenXmlElement type.</returns>
  /// <exception cref="InvalidProgramException">Thrown if the "Val" or "Value" property is not found on the element type.</exception>
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(this OnOffValue value)
  where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var openXmlElement = new OpenXmlElementType();
    var valueProp = typeof(OpenXmlElementType).GetProperty("Val") ?? typeof(OpenXmlElementType).GetProperty("Value");
    if (valueProp == null)
      throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(OpenXmlElementType)}");
    valueProp.SetValue(openXmlElement, value);
    return openXmlElement;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.
  /// <summary>
  /// Retrieves a boolean value from the text content of a TypedOpenXmlLeaf element.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement to check.</param>
  /// <returns>True for "true" or "1", false for "false" or "0", or null.</returns>
  public static bool? GetBoolTextVal(this DX.OpenXmlLeafTextElement? element)
  {
    if (element?.Text != null)
    {
      var text = element.Text.ToLower();
      switch (text)
      {
        case "true": return true;
        case "false": return false;
        case "1": return true;
        case "0": return false;
      }
    }
    return null;
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElementType with text content "1" or "0" based on the boolean value.
  /// </summary>
  /// <typeparam name="OpenXmlLeafTextElementType">The type of the element to create.</typeparam>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>A new element with content "1" or "0", or null if value is null.</returns>
  public static OpenXmlLeafTextElementType? CreateOpenXmlLeafTextElement<OpenXmlLeafTextElementType>(this bool? value)
  where OpenXmlLeafTextElementType : OpenXmlLeafTextElement, new()
  {
    if (value != null)
    {
      var element = new OpenXmlLeafTextElementType();
      if (value == true)
      {
        element.Text = "1";
      }
      else
      if (value == false)
      {
        element.Text = "0";
      }
      return element;
    }
    return null;
  }
  #endregion

  #region String value conversion.
  /// <summary>
  /// Retrieves a boolean value from a "0" or "1" string.
  /// </summary>
  /// <param name="str">The string to check.</param>
  /// <returns>True if string is "1", false otherwise (including null).</returns>
  public static Boolean? GetBoolValue(this string? str)
  {
    if (str != null)
      return str == "1";
    else
      return null;
  }

  /// <summary>
  /// Creates a "0" or "1" string from a boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>"1" if true, "0" if false, or null if value is null.</returns>
  public static string? Create01String(this Boolean? value)
  {
    if (value == null) return null;
    return (Boolean)value ? "1" : "0";
  }
  #endregion

  #region Specific Boolean values element conversion.
  /// <summary>
  /// Creates a Word 2010 OnOffType element from a boolean value.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the Word 2010 OnOffType element.</typeparam>
  /// <param name="value">The boolean value.</param>
  /// <returns>A new element with the value set.</returns>
  /// <exception cref="InvalidProgramException">Thrown if "Val" or "Value" property not found.</exception>
  public static OpenXmlElementType CreateWordOpenXmlElement<OpenXmlElementType>(this Boolean value)
  where OpenXmlElementType : DXO10W.OnOffType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    var valueProp = typeof(OpenXmlElementType).GetProperty("Val") ?? typeof(OpenXmlElementType).GetProperty("Value");
    if (valueProp == null)
      throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(OpenXmlElementType)}");
    //if (value==true)
    //  valueProp.SetValue(openXmlElement, new DX.EnumValue<DXM.BooleanValues>(DXM.BooleanValues.One));
    //else
    if (value == false)
      valueProp.SetValue(openXmlElement, new DX.EnumValue<DXO10W.OnOffValues>(DXO10W.OnOffValues.Zero));
    return openXmlElement;
  }

  /// <summary>
  /// Creates a Math OnOffType element from a boolean value.
  /// </summary>
  /// <typeparam name="ElementType">The type of the element.</typeparam>
  /// <param name="value">The boolean value.</param>
  /// <returns>A new element with the value set.</returns>
  /// <exception cref="InvalidProgramException">Thrown if "Val" or "Value" property not found.</exception>
  public static ElementType CreateMathOpenXmlElement<ElementType>(this Boolean value)
  where ElementType : DX.OpenXmlElement, new()
  {
    var openXmlElement = new ElementType();
    var valueProp = typeof(ElementType).GetProperty("Val") ?? typeof(ElementType).GetProperty("Value");
    if (valueProp == null)
      throw new InvalidProgramException($"Property \"Value\" not found in type {typeof(ElementType)}");
    //if (value==true)
    //  valueProp.SetValue(openXmlElement, new DX.EnumValue<DXM.BooleanValues>(DXM.BooleanValues.One));
    //else
    if (value == false)
      valueProp.SetValue(openXmlElement, new DX.EnumValue<DXM.BooleanValues>(DXM.BooleanValues.Zero));
    return openXmlElement;
  }
  #endregion

  #region Boolean get/set methods
  /// <summary>
  /// Retrieves a boolean value from a child OnOffType element within an OpenXml CompositeElement.
  /// Handles standard Word, Word 2013, and Math OnOffType elements.
  /// </summary>
  /// <typeparam name="OpenXmlType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <returns>The boolean value, or null if not found.</returns>
  /// <exception cref="InvalidDataException">Thrown if an invalid Math OnOffType value is encountered.</exception>
  public static bool? GetBoolVal<OpenXmlType>(this DX.OpenXmlCompositeElement? openXmlElement) where OpenXmlType : DX.OpenXmlLeafElement
  {
    if (openXmlElement != null)
    {
      var element = openXmlElement.Elements<OpenXmlElement>().FirstOrDefault();
      if (element != null)
      {
        if (element is DXW.OnOffType onOffType)
        {
          if (onOffType.Val?.HasValue == true)
            return onOffType.Val.Value;
          return true;
        }
        else
        if (element is DXO13W.OnOffType onOffType13)
        {
          if (onOffType13.Val?.HasValue == true)
            return onOffType13.Val.Value;
          return true;
        }
        else
        if (element is DXM.OnOffType onOffTypeM)
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

  /// <summary>
  /// Sets a boolean value on a child OnOffType element within an OpenXml CompositeElement.
  /// Creates the element if it doesn't exist, remove if value is null.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the child element.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">The boolean value to set.</param>
  public static void SetBoolVal<OpenXmlElementType>(this DX.OpenXmlCompositeElement openXmlElement, bool? value) where OpenXmlElementType : DX.OpenXmlLeafElement, new()
  {
    if (value != null)
    {
      var element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (element == null)
      {
        element = new OpenXmlElementType();
        openXmlElement.AppendChild(element);
      }
      if (element is DXW.OnOffType onOffType)
        onOffType.Val = value;
      else
      if (element is DXO13W.OnOffType onOffType13)
        onOffType13.Val = value;
      else
      if (element is DXM.OnOffType onOffTypeM)
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
      var _element = openXmlElement.Elements<OpenXmlElementType>().FirstOrDefault();
      if (_element != null)
        _element.Remove();
    }
  }

  /// <summary>
  /// Checks for the existence of a specific OpenXmlEmptyType element.
  /// </summary>
  /// <typeparam name="OpenXmlElementType">The type of the element to check for.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <returns>True if the element exists, otherwise false (or null if parent is null).</returns>
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
  /// Adds or removes an OpenXmlEmptyType element based on a boolean value.
  /// </summary>
  /// <typeparam name="ElementType">The type of the element to add/remove.</typeparam>
  /// <param name="openXmlElement">The parent composite element.</param>
  /// <param name="value">True to add the element, false to remove it.</param>
  public static void SetExistsIfTrue<ElementType>(this DX.OpenXmlCompositeElement openXmlElement, bool? value) where ElementType : DXW.EmptyType, new()
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

}