namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods for boolean values to/from Open XML.
/// </summary>
public static class BooleanConverter/* : BaseConverter<Boolean>*/
{
  private static readonly (Type TargetType, string ConvertFromMethod, string ConvertToMethod)[] supportedTypes =
  [
    (typeof(DX.OnOffValue), nameof(ConvertFromOnOffValue), nameof(ConvertToOnOffValue)),
    (typeof(DXW.OnOffOnlyValues), nameof(ConvertFromOnOffOnlyValues), nameof(ConvertToOnOffOnlyValues)),
    (typeof(DXO10W.OnOffValues), nameof(ConvertFromO10WOnOffValues), nameof(ConvertToO10WOnOffValues)),
    (typeof(DXW.OnOffType), nameof(ConvertFromOnOffType), nameof(ConvertToOnOffType)),
    (typeof(DXM.OnOffType), nameof(ConvertFromMathOnOffType), nameof(ConvertToMathOnOffType)),
    (typeof(DXO10W.OnOffType), nameof(ConvertFromO10WOnOffType), nameof(ConvertToO10WOnOffType)),
    (typeof(DXO13W.OnOffType), nameof(ConvertFromO13WOnOffType), nameof(ConvertToO13WOnOffType)),
    (typeof(DXW.OnOffOnlyType), nameof(ConvertFromOnOffOnlyType), nameof(ConvertToOnOffOnlyType)),
    (typeof(DX.BooleanValue), nameof(ConvertFromBooleanValue), nameof(ConvertToBooleanValue)),
    (typeof(DXM.BooleanValues), nameof(ConvertFromBooleanValues), nameof(ConvertToBooleanValues)),
    (typeof(DX.TrueFalseValue), nameof(ConvertFromTrueFalseValue), nameof(ConvertToTrueFalseValue)),

    //(typeof(DX.EnumValue<DXW.OnOffOnlyValues>), nameof(ConvertFromEnumValueOfOnOffOnlyValues), nameof(ConvertToEnumValueOfOnOffOnlyValues)),
    //(typeof(DX.EnumValue<DXO10W.OnOffValues>), nameof(ConvertFromEnumValueOfO10WOnOffValues), nameof(ConvertToEnumValueOfO10WOnOffValues)),
    ////(typeof(DX.EnumValue<DXM.BooleanValues>), nameof(ConvertFromEnumValueOfBooleanValues), nameof(ConvertToEnumValueOfBooleanValues)),


    //(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    //(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
    //(typeof(string), nameof(ConvertFromString), nameof(ConvertToString)),
  ];

  //public override Type[] SupportedTypes => supportedTypes.Select(item=>item.TargetType).ToArray();

  internal static readonly Dictionary<(Type Source, Type Target), Func<object,  Type, object?>> ConversionToMap = new();
  internal static readonly Dictionary<(Type Source, Type Target), Func<object, object?>> ConversionFromMap = new();

  static BooleanConverter()
  {
    //// Register conversion functions
    //RegisterConversion<string, Boolean>(value => Boolean.Parse(value.ToString()!));
    //RegisterConversion<Boolean, string>(value => value.ToString());
    foreach (var item in supportedTypes)
    {
      var fromMethod = typeof(BooleanConverter).GetMethod(item.ConvertFromMethod, BindingFlags.Public | BindingFlags.Static);
      var toMethod = typeof(BooleanConverter).GetMethod(item.ConvertToMethod, BindingFlags.Public | BindingFlags.Static);
      if (fromMethod != null)
      {
        ConversionFromMap[(item.TargetType, typeof(Boolean))] = value => fromMethod.Invoke(null, [value])!;
      }
      if (toMethod != null)
      {
        ConversionToMap[(typeof(Boolean), item.TargetType)] = (value, targetType) =>
        {
          var parameters = toMethod.GetParameters();
          if (parameters.Length == 1)
            return toMethod.Invoke(null, [value])!;

          return toMethod.Invoke(null, [value, targetType])!;
        };
      }
    }
  }



  #region OnOffValue conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified OnOffValue element.
  /// </summary>
  /// <param name="element">The OnOffValue element to check.</param>
  /// <returns>A boolean representing the value, or null if the element is null.</returns>
  public static Boolean ConvertFromOnOffValue(DX.OnOffValue element)
  {
    return element.Value;
  }

  /// <summary>
  /// Creates an OnOffValue using specified string representations for false and true.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="falseString">The string representation for false (default is "0").</param>
  /// <param name="trueString">The string representation for true (default is "1").</param>
  /// <returns>A new OnOffValue object, or null if the input value is null.</returns>
  public static DX.OnOffValue ConvertToOnOffValue(Boolean value)
  {
    var val = value ? "1" : "0";

    return new DX.OnOffValue { InnerText = val };
  }

  #endregion

  #region OnOffOnlyValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified OnOffOnlyValues element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyValues element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  public static Boolean ConvertFromOnOffOnlyValues(DXW.OnOffOnlyValues openXmlElement)
  {
    return openXmlElement == DXW.OnOffOnlyValues.On;
  }

  /// <summary>
  /// Creates an OnOffOnlyValues element from the specified boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>OnOffOnlyValues.On if true, OnOffOnlyValues.Off if false, otherwise null.</returns>
  public static DXW.OnOffOnlyValues ConvertToOnOffOnlyValues(Boolean value)
  {
    if (value) return DXW.OnOffOnlyValues.On;

    return DXW.OnOffOnlyValues.Off;
  }

  #endregion

  #region EnumValue<OnOffOnlyValues> conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified EnumValue&lt;OnOffOnlyValues&gt; element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyValues element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  public static Boolean ConvertFromEnumValueOfOnOffOnlyValues(DX.EnumValue<DXW.OnOffOnlyValues> openXmlElement)
  {
    return openXmlElement == DXW.OnOffOnlyValues.On;
  }

  /// <summary>
  /// Creates an EnumValue&lt;OnOffOnlyValues&gt; element from the specified boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>OnOffOnlyValues.On if true, OnOffOnlyValues.Off if false, otherwise null.</returns>
  public static DX.EnumValue<DXW.OnOffOnlyValues> ConvertToEnumValueOfOnOffOnlyValues(Boolean value)
  {
    if (value) return new DX.EnumValue<DXW.OnOffOnlyValues>(DXW.OnOffOnlyValues.On);
    return new DX.EnumValue<DXW.OnOffOnlyValues>(DXW.OnOffOnlyValues.Off);
  }

  #endregion

  #region TrueFalseValue conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified TrueFalseValue element.
  /// </summary>
  /// <param name="value">The TrueFalseValue element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  public static Boolean ConvertFromTrueFalseValue(DX.TrueFalseValue value)
  {
    return DX.TrueFalseValue.ToBoolean(value);
  }

  /// <summary>
  /// Creates an TrueFalseValue element from the specified boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>TrueFalseValue.On if true, TrueFalseValue.Off if false, otherwise null.</returns>
  public static DX.TrueFalseValue ConvertToTrueFalseValue(Boolean value)
  {
    return new DX.TrueFalseValue(value);
  }

  #endregion

  #region DXW.OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified DXW.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null.</returns>
  public static Boolean ConvertFromOnOffType(DXW.OnOffType openXmlElement)
  {
    return openXmlElement.Val?.Value ?? true;
  }

  /// <summary>
  /// Creates a new instance of the specified DXW.OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXW.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXW.OnOffType ConvertToOnOffType(Boolean value, Type targetType)
  {
    if (targetType.GetConstructor([typeof(Boolean)]) != null)
      return (DXW.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXW.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region DXW.OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified DXW.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null.</returns>
  public static Boolean ConvertFromWordOnOffType(DXW.OnOffType openXmlElement)
  {
    var enumVal = openXmlElement.Val?.Value;
    if (enumVal == null)
      return true;

    return (bool)enumVal;
  }

  /// <summary>
  /// Creates a new instance of the specified DXO10W.OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXO10W.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXW.OnOffType ConvertToWordOnOffType(Boolean value, Type targetType)
  {
    if (targetType.GetConstructor([typeof(Boolean)]) != null)
      return (DXW.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXW.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region DXO13W.OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified DXO13W.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null.</returns>
  public static Boolean ConvertFromO13WOnOffType(DXO13W.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return true;

    var enumVal = openXmlElement.Val?.Value;
    if (enumVal == null)
      return true;

    return (bool)enumVal;
  }

  /// <summary>
  /// Creates a new instance of the specified DXO13W.OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXO13W.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXO13W.OnOffType ConvertToO13WOnOffType(Boolean value, Type targetType)
  {
    if (targetType.GetConstructor([typeof(Boolean)]) != null)
      return (DXO13W.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXO13W.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region DXM.OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified DXM.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null.</returns>
  public static Boolean ConvertFromMathOnOffType(DXM.OnOffType openXmlElement)
  {
    var enumVal = openXmlElement.Val?.Value;
    if (enumVal == null)
      return true;

    if (enumVal == DXM.BooleanValues.True
        || enumVal == DXM.BooleanValues.One
        || enumVal == DXM.BooleanValues.On)
      return true;
    if (enumVal == DXM.BooleanValues.False
        || enumVal == DXM.BooleanValues.Zero
        || enumVal == DXM.BooleanValues.Off)
      return false;

    throw new InvalidOperationException("Unknown OnOffType value.");
  }

  /// <summary>
  /// Creates a new instance of the specified DXM.OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXM.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>.</returns>
  public static DXM.OnOffType ConvertToMathOnOffType(Boolean value, Type targetType)
  {
    if (targetType.GetConstructor([typeof(Boolean)]) != null)
      return (DXM.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXM.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = (bool)value ? DXM.BooleanValues.One : DXM.BooleanValues.Zero;
    return element;
  }

  #endregion

  #region OnOffOnlyType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified OnOffOnlyType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyType element to check.</param>
  /// <returns>True if the value is On, false if the value is Off, or true if the element exists without a value.</returns>
  public static Boolean ConvertFromOnOffOnlyType(DXW.OnOffOnlyType openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      return openXmlElement.Val.Value == DXW.OnOffOnlyValues.On;

    return openXmlElement != null;
  }

  /// <summary>
  /// Creates a new instance of the specified OnOffOnlyType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffOnlyType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXW.OnOffOnlyType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXW.OnOffOnlyType ConvertToOnOffOnlyType(Boolean value, Type targetType)
  {
    var element = (DXW.OnOffOnlyType)Activator.CreateInstance(targetType)!;
    element.Val = new DX.EnumValue<DXW.OnOffOnlyValues>(value ? DXW.OnOffOnlyValues.On : DXW.OnOffOnlyValues.Off);
    return element;
  }

  #endregion

  #region Office2010 Word OnOffValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="value">The OnOffValues to get boolean value.</param>
  /// <returns>True for True/One, false for False/Zero.</returns>
  public static Boolean ConvertFromO10WOnOffValues(DXO10W.OnOffValues value)
  {
    if (value == DXO10W.OnOffValues.True || value == DXO10W.OnOffValues.One)
      return true;
    if (value == DXO10W.OnOffValues.False || value == DXO10W.OnOffValues.Zero)
      return false;

    throw new InvalidOperationException($"Invalid value {value} in OnOffValues");
  }

  /// <summary>
  /// Converts a nullable Boolean value to its corresponding Open XML OnOffValues enumeration value.
  /// </summary>
  /// <param name="value">The nullable Boolean value to convert. If <see langword="true"/>, returns <c>OnOffValues.One</c>; if <see
  /// langword="false"/>, returns <c>OnOffValues.Zero</c>; if <see langword="null"/>, returns <see langword="null"/>.</param>
  /// <returns>A <c>DXO10W.OnOffValues</c> value representing the Boolean input.</returns>
  public static DXO10W.OnOffValues? ConvertToO10WOnOffValues(Boolean value)
  {
    return value == true ? DXO10W.OnOffValues.One : DXO10W.OnOffValues.Zero;
  }

  #endregion

  #region EnumValue of Office2010 Word OnOffValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  public static Boolean ConvertFromEnumValueOfO10WOnOffValues(DX.EnumValue<DXO10W.OnOffValues> openXmlElement)
  {
    var value = openXmlElement.Value;
    if (value == DXO10W.OnOffValues.True || value == DXO10W.OnOffValues.One)
      return true;
    if (value == DXO10W.OnOffValues.False || value == DXO10W.OnOffValues.Zero)
      return false;

    throw new InvalidOperationException($"Invalid value {value} in OnOffValues");
  }

  /// <summary>
  /// Converts a boolean value to enum value of Office2010 Word OnOffValue.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>An <see cref="OnOffValues"/> corresponding to the specified Boolean value, or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DX.EnumValue<DXO10W.OnOffValues> ConvertToEnumValueOfO10WOnOffValues(Boolean value)
  {
    return new DX.EnumValue<DXO10W.OnOffValues>(value ? DXO10W.OnOffValues.One : DXO10W.OnOffValues.Zero);
  }

  #endregion

  #region Office2010 Word OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero.</returns>
  public static Boolean ConvertFromO10WOnOffType(DXO10W.OnOffType openXmlElement)
  {
    var value = openXmlElement.Val?.Value;
    if (value == DXO10W.OnOffValues.True || value == DXO10W.OnOffValues.One)
      return true;
    if (value == DXO10W.OnOffValues.False || value == DXO10W.OnOffValues.Zero)
      return false;

    throw new InvalidOperationException($"Invalid value {value} in OnOffValues");
  }

  /// <summary>
  /// Creates a new instance of the specified OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXW.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>.</returns>
  public static DXO10W.OnOffType ConvertToO10WOnOffType(Boolean value, Type targetType)
  {
    if (targetType.GetConstructor([typeof(bool)]) != null)
      return (DXO10W.OnOffType)Activator.CreateInstance(targetType, value == true)!;

    var element = (DXO10W.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = new DX.EnumValue<DXO10W.OnOffValues>(value == true ? DXO10W.OnOffValues.One : DXO10W.OnOffValues.Zero);
    return element;
  }

  #endregion

  #region Office2010 Word OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2013 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  public static Boolean ConvertToBool(DXO13W.OnOffType openXmlElement)
  {
    return openXmlElement.Val?.Value ?? true;
  }

  /// <summary>
  /// Creates a new instance of the specified Word 2013 OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the Word 2013 OnOffType element.</param>
  /// <param name="targetType">The type of Word 2013 OnOffType to instantiate. Must be a type derived from DXO13W.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>.</returns>
  public static DXO13W.OnOffType CreateOnOff13Type(Boolean value, Type targetType)
  {
    if (targetType.GetConstructor([typeof(bool)]) != null)
      return (DXO13W.OnOffType)Activator.CreateInstance(targetType, value == true)!;

    var element = (DXO13W.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region BooleanValue conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified BooleanValue comparable simple value.
  /// </summary>
  /// <param name="value">The value to convert</param>
  /// <returns>True for True/On/One, false for False/Off/Zero, or null.</returns>
  public static Boolean ConvertFromBooleanValue(DX.BooleanValue value)
  {
    return value;
  }

  /// <summary>
  /// Converts a nullable Boolean value to its corresponding OpenXml BooleanValue representation.
  /// </summary>
  /// <param name="value">The nullable Boolean value to convert. If null, the method returns null.</param>
  /// <returns>A DX.BooleanValue value representing the Boolean input</returns>
  public static DX.BooleanValue ConvertToBooleanValue(Boolean value)
  {
    return new DX.BooleanValue(value);
  }

  #endregion

  #region Math BooleanValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Math BooleanValues enum value.
  /// </summary>
  /// <param name="value">The value to convert</param>
  /// <returns>True for True/On/One, false for False/Off/Zero, or null.</returns>
  public static Boolean ConvertFromBooleanValues(DXM.BooleanValues value)
  {
    if (value == DXM.BooleanValues.True || value == DXM.BooleanValues.On || value == DXM.BooleanValues.One)
      return true;
    if (value == DXM.BooleanValues.False || value == DXM.BooleanValues.Off || value == DXM.BooleanValues.Zero)
      return false;

    throw new InvalidOperationException("Invalid Math BooleanValues");
  }

  /// <summary>
  /// Converts a nullable Boolean value to its corresponding OpenXml Math BooleanValues representation.
  /// </summary>
  /// <param name="value">The nullable Boolean value to convert. If null, the method returns null.</param>
  /// <returns>A DXM.BooleanValues value representing the Boolean input: DXM.BooleanValues.One if <paramref name="value"/> is
  /// <see langword="true"/>, DXM.BooleanValues.Zero if <paramref name="value"/> is <see langword="false"/>, or null if
  /// <paramref name="value"/> is null.</returns>
  public static DXM.BooleanValues ConvertToBooleanValues(Boolean value)
  {
    return value ? DXM.BooleanValues.One : DXM.BooleanValues.Zero;
  }

  #endregion

  #region EnumValue of Office2010 Word OnOffValues conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  public static Boolean ConvertBoolValuesEnumToBool(DX.EnumValue<DXM.BooleanValues> openXmlElement)
  {

    var value = openXmlElement.Value;
    if (value == DXM.BooleanValues.True || value == DXM.BooleanValues.On || value == DXM.BooleanValues.One)
      return true;
    if (value == DXM.BooleanValues.False || value == DXM.BooleanValues.Off || value == DXM.BooleanValues.Zero)
      return false;
    throw new InvalidOperationException("Invalid Math BooleanValues");
  }

  /// <summary>
  /// Converts a boolean value to enum value of Office2010 Word OnOffValue.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <returns>An <see cref="OnOffValues"/> corresponding to the specified Boolean value, or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DX.EnumValue<DXM.BooleanValues>? CreateMathOnOffEnumValue(Boolean value)
  {
    return new DX.EnumValue<DXM.BooleanValues>(value == true ? DXM.BooleanValues.One : DXM.BooleanValues.Zero);
  }

  #endregion

  #region Math OnOffType conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified Math OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The Math OnOffType element to check.</param>
  /// <returns>The boolean value, true if element exists but value is null.</returns>
  public static Boolean ConvertToBool(DXM.OnOffType openXmlElement)
  {
    if (openXmlElement?.Val?.Value != null)
      // ReSharper disable once InvokeAsExtensionMember
      return ConvertBoolValuesEnumToBool(openXmlElement.Val.Value);
    if (openXmlElement != null) return true;

    return true;
  }

  /// <summary>
  /// Creates a new instance of the specified Math OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXM.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXM.OnOffType CreateMathOnOffType(Boolean value, Type targetType)
  {
    var element = (DXM.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = new DX.EnumValue<DXM.BooleanValues>(value == true ? DXM.BooleanValues.One : DXM.BooleanValues.Zero);
    return element;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Retrieves a boolean value from the text content of a OpenXmlLeafTextElement element.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement to check.</param>
  /// <returns>True for "true" or "1", false for "false" or "0", or null.</returns>
  public static bool ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? element)
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
    throw new InvalidOperationException("Invalid OpenXmlLeafTextElement");
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElement with text content "1" or "0" based on the boolean value.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="targetType">The type of the element to create.</param>
  /// <returns>A new element with content "1" or "0".</returns>
  public static DX.OpenXmlLeafTextElement ConvertToOpenXmlLeafTextElement(bool value, Type targetType)
  {
    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    if (value)
    {
      element.Text = "1";
    }
    else if (value == false)
    {
      element.Text = "0";
    }
    return element;
  }

  #endregion

  #region DXW.OpenXmlLeafElement conversion.

  /// <summary>
  /// Retrieves a boolean value from the specified DX.OpenXmlLeafElement element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlLeafElement to check.</param>
  /// <returns>The boolean value, true if element exists but value is null.</returns>
  public static Boolean ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement openXmlElement)
  {
    var valProp = openXmlElement.GetType().GetProperty("Val");
    if (valProp == null)
      throw new InvalidOperationException("The Val property is not found in " + openXmlElement.GetType().Name);
    return (Boolean)valProp.GetValue(openXmlElement)!;
  }

  /// <summary>
  /// Creates a new instance of the specified DX.OpenXmlLeafElement and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OpenXmlLeafElement element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OpenXmlLeafElement to instantiate. Must be a type derived from DX.OpenXmlLeafElement.</param>
  /// <returns>A new instance of the specified OpenXmlLeafElement with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXW.OnOffType ConvertToOpenXmlLeafElement(Boolean value, Type targetType)
  {
    if (targetType.GetConstructor([typeof(Boolean)]) != null)
      return (DXW.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXW.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion


  #region string conversion.

  /// <summary>
  /// Converts the specified string representation of a logical value to its nullable Boolean equivalent.
  /// </summary>
  /// <remarks>If <paramref name="value"/> is <see langword="null"/>, the method returns <see langword="true"/>.
  /// Any other input that does not match the accepted values results in <see langword="null"/>.</remarks>
  /// <param name="value">The string to convert. Accepts "true", "false", "1", or "0" (case-insensitive).</param>
  /// <returns>A nullable Boolean value: <see langword="true"/> if <paramref name="value"/> is "true" or "1"; <see
  /// langword="false"/> if <paramref name="value"/> is "false" or "0"; otherwise, <see langword="null"/>.</returns>
  public static Boolean ConvertFromString(string? value)
  {
    if (value == null) return true;

    value = value.ToLower();

    if (value == "true" || value == "1")
      return true;
    if (value == "false" || value == "0")
      return false;
    throw new InvalidOperationException($"Invalid boolean string: {value}");
  }

  /// <summary>
  /// Creates a new instance of the specified DXW.OnOffType and sets its value to the provided Boolean value.
  /// </summary>
  /// <param name="value">The Boolean value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXW.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  public static DXW.OnOffType ConvertToString(Boolean value, Type targetType)
  {
    if (targetType.GetConstructor([typeof(Boolean)]) != null)
      return (DXW.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXW.OnOffType)Activator.CreateInstance(targetType)!;
    element.Val = value;
    return element;
  }

  #endregion

  #region Generic OpenXml boolean converter

  /// <summary>
  /// Converts a boolean value to an OpenXml value or element of the specified type.
  /// </summary>
  /// <param name="value">The boolean value to convert.</param>
  /// <param name="targetType">The type of the OpenXml element to create.</param>
  /// <returns>An OpenXml element representing the boolean value.</returns>
  /// <exception cref="NotSupportedException"></exception>
  public static object? ConvertToOpenXml(bool value, Type targetType)
  {
    if (ConversionToMap.TryGetValue((typeof(bool), targetType), out var conversionFunc))
    {
      return conversionFunc(value, targetType);
    }

    throw new NotSupportedException($"Conversion from Boolean to type {targetType} is not supported.");
  }

  /// <summary>
  /// Converts an OpenXml value or element to a boolean value.
  /// </summary>
  /// <param name="value">The OpenXml value or element to convert.</param>
  /// <returns>The boolean value represented by the element, or null if the element is null.</returns>
  /// <exception cref="NotSupportedException"></exception>
  public static bool ConvertFromOpenXml(object value)
  {
    var sourceType = value.GetType();
    if (ConversionFromMap.TryGetValue((sourceType, typeof(bool)), out var conversionFunc))
    {
      return (bool)conversionFunc(value)!;
    }

    throw new NotSupportedException($"Conversion from type {sourceType} to Boolean is not supported.");
  }

  #endregion
}