namespace DocumentModel.OpenXml;

/// <summary>
/// Translates between the tri-state <see cref="OnOffToggle"/> model value and supported Open XML representations.
/// </summary>
public static class OnOffToggleConverter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DXW.EmptyType), nameof(ConvertFromEmptyType), nameof(ConvertToEmptyType)),
    new(typeof(DX.OnOffValue), nameof(ConvertFromOnOffValue), nameof(ConvertToOnOffValue)),
    new(typeof(DXW.OnOffOnlyValues), nameof(ConvertFromOnOffOnlyValues), nameof(ConvertToOnOffOnlyValues)),
    new(typeof(DXO10W.OnOffValues), nameof(ConvertFromO10WOnOffValues), nameof(ConvertToO10WOnOffValues)),
    new(typeof(DXW.OnOffType), nameof(ConvertFromOnOffType), nameof(ConvertToOnOffType)),
    new(typeof(DXM.OnOffType), nameof(ConvertFromMathOnOffType), nameof(ConvertToMathOnOffType)),
    new(typeof(DXO10W.OnOffType), nameof(ConvertFromO10WOnOffType), nameof(ConvertToO10WOnOffType)),
    new(typeof(DXO13W.OnOffType), nameof(ConvertFromO13WOnOffType), nameof(ConvertToO13WOnOffType)),
    new(typeof(DXW.OnOffOnlyType), nameof(ConvertFromOnOffOnlyType), nameof(ConvertToOnOffOnlyType)),
    new(typeof(DX.BooleanValue), nameof(ConvertFromBooleanValue), nameof(ConvertToBooleanValue)),
    new(typeof(DXM.BooleanValues), nameof(ConvertFromBooleanValues), nameof(ConvertToBooleanValues)),
    new(typeof(DX.TrueFalseValue), nameof(ConvertFromTrueFalseValue), nameof(ConvertToTrueFalseValue)),
    new(typeof(DX.TrueFalseBlankValue), nameof(ConvertFromTrueFalseBlankValue), nameof(ConvertToTrueFalseBlankValue)),
    new(typeof(DX.EnumValue<DXW.OnOffOnlyValues>), nameof(ConvertFromEnumValueOfOnOffOnlyValues), nameof(ConvertToEnumValueOfOnOffOnlyValues)),
    new(typeof(DX.EnumValue<DXO10W.OnOffValues>), nameof(ConvertFromEnumValueOfO10WOnOffValues), nameof(ConvertToEnumValueOfO10WOnOffValues)),
    new(typeof(DX.EnumValue<DXM.BooleanValues>), nameof(ConvertFromEnumValueOfOnOffValues), nameof(ConvertToEnumValueOfOnOffValues)),
    new(typeof(DX.OpenXmlLeafTextElement), nameof(ConvertFromOpenXmlLeafTextElement), nameof(ConvertToOpenXmlLeafTextElement)),
    new(typeof(DX.OpenXmlLeafElement), nameof(ConvertFromOpenXmlLeafElement), nameof(ConvertToOpenXmlLeafElement)),
    new(typeof(string), nameof(OnOffToggleFromString), nameof(OnOffToggleToString))
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps for <see cref="OnOffToggleConverter"/>.
  /// </summary>
  static OnOffToggleConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(OnOffToggleConverter), typeof(OnOffToggle), supportedConversions, ConversionToMap, ConversionFromMap);
  }


  #region EmptyType conversion.

  /// <summary>
  /// Converts a nullable Open XML EmptyType element to a OnOffToggle value.
  /// </summary>
  /// <param name="openXmlElement">The Open XML EmptyType element to convert. If null, the method returns null.</param>
  /// <returns>A OnOffToggle value that is <see langword="true"/> if <paramref name="openXmlElement"/> is not null;
  /// otherwise, <see langword="false"/>.</returns>
  private static OnOffToggle ConvertFromEmptyType(DXW.EmptyType? openXmlElement)
  {
    if (openXmlElement == null) return OnOffToggle.Undefined;

    return OnOffToggle.On;
  }

  /// <summary>
  /// Converts a nullable OnOffToggle value to a new instance of the specified DXW.EmptyType, or returns null if the value
  /// is null or false.
  /// </summary>
  /// <param name="value">The nullable OnOffToggle value to convert. If null or <see langword="false"/>, the method returns null.</param>
  /// <param name="targetType">The type of DXW.EmptyType to instantiate if <paramref name="value"/> is <see langword="true"/>. Must be a type
  /// that derives from DXW.EmptyType and has a parameterless constructor.</param>
  /// <returns>A new instance of the specified DXW.EmptyType if <paramref name="value"/> is <see langword="true"/>; otherwise,
  /// null.</returns>
  private static DXW.EmptyType? ConvertToEmptyType(OnOffToggle? value, Type targetType)
  {
    if (value == null) return null;
    if (value.Equals(false)) return null;

    return (DXW.EmptyType)Activator.CreateInstance(targetType)!;
  }

  #endregion

  #region OnOffOnlyValues conversion.

  /// <summary>
  /// Retrieves a OnOffToggle value from the specified OnOffOnlyValues element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyValues element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  private static OnOffToggle? ConvertFromOnOffOnlyValues(DXW.OnOffOnlyValues? openXmlElement)
  {
    if (openXmlElement == null) return null;

    if (openXmlElement == DXW.OnOffOnlyValues.On)
      return OnOffToggle.On;
    if (openXmlElement == DXW.OnOffOnlyValues.Off)
      return OnOffToggle.Off;

    return OnOffToggle.Toggle;
  }

  /// <summary>
  /// Creates an OnOffOnlyValues element from the specified OnOffToggle value.
  /// </summary>
  /// <param name="value">The OnOffToggle value to convert.</param>
  /// <returns>OnOffOnlyValues.On if true, OnOffOnlyValues.Off if false, otherwise null.</returns>
  private static DXW.OnOffOnlyValues? ConvertToOnOffOnlyValues(OnOffToggle? value)
  {
    if (value == null) return null;
    if (value == OnOffToggle.On) return DXW.OnOffOnlyValues.On;
    if (value == OnOffToggle.Off) return DXW.OnOffOnlyValues.Off;

    return null;
  }

  #endregion

  #region EnumValue<OnOffOnlyValues> conversion.

  /// <summary>
  /// Retrieves a OnOffToggle value from the specified EnumValue&lt;OnOffOnlyValues&gt; element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyValues element to check.</param>
  /// <returns>True if the value is On, otherwise null or false.</returns>
  private static OnOffToggle? ConvertFromEnumValueOfOnOffOnlyValues(DX.EnumValue<DXW.OnOffOnlyValues>? openXmlElement)
  {
    if (openXmlElement == null) return null;

    if (openXmlElement == DXW.OnOffOnlyValues.On)
      return OnOffToggle.On;
    if (openXmlElement == DXW.OnOffOnlyValues.Off)
      return OnOffToggle.Off;

    return OnOffToggle.Toggle;
  }

  /// <summary>
  /// Creates an EnumValue&lt;OnOffOnlyValues&gt; element from the specified OnOffToggle value.
  /// </summary>
  /// <param name="value">The OnOffToggle value to convert.</param>
  /// <returns>OnOffOnlyValues.On if true, OnOffOnlyValues.Off if false, otherwise null.</returns>
  private static DX.EnumValue<DXW.OnOffOnlyValues>? ConvertToEnumValueOfOnOffOnlyValues(OnOffToggle? value)
  {
    if (value == null) return null;

    if (value == OnOffToggle.On) return new DX.EnumValue<DXW.OnOffOnlyValues>(DXW.OnOffOnlyValues.On);

    if (value == OnOffToggle.Off) return new DX.EnumValue<DXW.OnOffOnlyValues>(DXW.OnOffOnlyValues.Off);

    return null;
  }

  #endregion

  #region TrueFalseValue conversion.

  /// <summary>
  /// Retrieves a OnOffToggle openXmlElement from the specified TrueFalseValue element.
  /// </summary>
  /// <param name="openXmlElement">The TrueFalseValue element to check.</param>
  /// <returns>True if the openXmlElement is On, otherwise null or false.</returns>
  private static OnOffToggle? ConvertFromTrueFalseValue(DX.TrueFalseValue? openXmlElement)
  {
    if (openXmlElement == null) return null;

    if (DX.TrueFalseValue.ToBoolean(openXmlElement))
      return OnOffToggle.On;
    else
      return OnOffToggle.Off;
  }

  /// <summary>
  /// Creates an TrueFalseValue element from the specified OnOffToggle value.
  /// </summary>
  /// <param name="value">The OnOffToggle value to convert.</param>
  /// <returns>TrueFalseValue.On if true, TrueFalseValue.Off if false, otherwise null.</returns>
  private static DX.TrueFalseValue? ConvertToTrueFalseValue(OnOffToggle? value)
  {
    if (value == null) return null;

    if (value == OnOffToggle.On) return new DX.TrueFalseValue(true);
    if (value == OnOffToggle.Off) return new DX.TrueFalseValue(false);
    return null;
  }

  #endregion


  #region TrueFalseOnlyValue conversion.

  /// <summary>
  /// Converts a <see cref="DX.TrueFalseBlankValue"/> into its <see cref="OnOffToggle"/> counterpart, preserving the blank state.
  /// </summary>
  /// <param name="value">The Open XML three-state value to interpret.</param>
  /// <returns>The equivalent <see cref="OnOffToggle"/> value.</returns>
  public static OnOffToggle ConvertFromTrueFalseBlankValue(DX.TrueFalseBlankValue value)
  {
    if (!value.HasValue) return OnOffToggle.Toggle;

    return DX.TrueFalseBlankValue.ToBoolean(value) ? OnOffToggle.On : OnOffToggle.Off;
  }

  /// <summary>
  /// Creates a <see cref="DX.TrueFalseBlankValue"/> that mirrors the supplied <see cref="OnOffToggle"/> state.
  /// </summary>
  /// <param name="value">The tri-state value to serialize.</param>
  /// <returns>A new <see cref="DX.TrueFalseBlankValue"/> instance representing the same logical state.</returns>
  public static DX.TrueFalseBlankValue? ConvertToTrueFalseBlankValue(OnOffToggle value)
  {
    if (value == OnOffToggle.Toggle)
      return new DX.TrueFalseBlankValue();

    return DX.TrueFalseBlankValue.FromBoolean(value == OnOffToggle.On);
  }

  #endregion

  #region DXW.OnOffType conversion.

  /// <summary>
  /// Retrieves a OnOffToggle value from the specified DXW.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The OnOffToggle value, true if element exists but value is null.</returns>
  private static OnOffToggle? ConvertFromOnOffType(DXW.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return null;
    if (openXmlElement.Val?.Value == null) return OnOffToggle.Toggle;

    if (openXmlElement.Val.Value)
      return OnOffToggle.On;
    else
      return OnOffToggle.Off;
  }

  /// <summary>
  /// Creates a new instance of the specified DXW.OnOffType and sets its value to the provided OnOffToggle value.
  /// </summary>
  /// <param name="value">The OnOffToggle value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXW.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  private static DXW.OnOffType? ConvertToOnOffType(OnOffToggle? value, Type targetType)
  {
    if (value == null) return null;

    if (targetType.GetConstructor([typeof(OnOffToggle)]) != null)
      return (DXW.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXW.OnOffType)Activator.CreateInstance(targetType)!;
    if (value == OnOffToggle.On)
      element.Val = true;
    else if (value == OnOffToggle.Off)
      element.Val = false;
    return element;
  }

  #endregion

  #region DXO13W.OnOffType conversion.

  /// <summary>
  /// Retrieves a OnOffToggle value from the specified DXO13W.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The OnOffToggle value, true if element exists but value is null.</returns>
  private static OnOffToggle? ConvertFromO13WOnOffType(DXO13W.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var boolVal = openXmlElement.Val?.Value;
    if (boolVal == null)
      return OnOffToggle.Toggle;

    return (bool)boolVal ? OnOffToggle.On : OnOffToggle.Off;
  }

  /// <summary>
  /// Creates a new instance of the specified DXO13W.OnOffType and sets its value to the provided OnOffToggle value.
  /// </summary>
  /// <param name="value">The OnOffToggle value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXO13W.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  private static DXO13W.OnOffType? ConvertToO13WOnOffType(OnOffToggle? value, Type targetType)
  {
    if (value == null) return null;

    if (targetType.GetConstructor([typeof(OnOffToggle)]) != null)
      return (DXO13W.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXO13W.OnOffType)Activator.CreateInstance(targetType)!;
    if (value == OnOffToggle.On)
      element.Val = true;
    else if (value == OnOffToggle.Off)
      element.Val = false;

    return element;
  }

  #endregion

  #region DXM.OnOffType conversion.

  /// <summary>
  /// Retrieves a OnOffToggle value from the specified DXM.OnOffType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffType element to check.</param>
  /// <returns>The OnOffToggle value, true if element exists but value is null.</returns>
  private static OnOffToggle? ConvertFromMathOnOffType(DXM.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var enumVal = openXmlElement.Val?.Value;
    if (enumVal == null)
      return OnOffToggle.Toggle;
    if (enumVal == DXM.BooleanValues.True || enumVal == DXM.BooleanValues.One || enumVal == DXM.BooleanValues.On)
      return OnOffToggle.On;
    if (enumVal == DXM.BooleanValues.False || enumVal == DXM.BooleanValues.Zero || enumVal == DXM.BooleanValues.Off)
      return OnOffToggle.Off;
    return OnOffToggle.Toggle;
  }

  /// <summary>
  /// Creates a new instance of the specified DXM.OnOffType and sets its value to the provided OnOffToggle value.
  /// </summary>
  /// <param name="value">The OnOffToggle value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXM.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>.</returns>
  private static DXM.OnOffType? ConvertToMathOnOffType(OnOffToggle? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.GetConstructor([typeof(OnOffToggle)]) != null)
      return (DXM.OnOffType)Activator.CreateInstance(targetType, value)!;

    var element = (DXM.OnOffType)Activator.CreateInstance(targetType)!;
    if (value == OnOffToggle.On)
      element.Val = DXM.BooleanValues.One;
    else if (value == OnOffToggle.Off)
      element.Val = DXM.BooleanValues.Zero;
    return element;
  }

  #endregion

  #region OnOffOnlyType conversion.

  /// <summary>
  /// Retrieves a OnOffToggle value from the specified OnOffOnlyType element.
  /// </summary>
  /// <param name="openXmlElement">The OnOffOnlyType element to check.</param>
  /// <returns>True if the value is On, false if the value is Off, or true if the element exists without a value.</returns>
  private static OnOffToggle? ConvertFromOnOffOnlyType(DXW.OnOffOnlyType? openXmlElement)
  {
    if (openXmlElement == null) return null;
    if (openXmlElement?.Val?.Value == null)
      return OnOffToggle.Toggle;

    if (openXmlElement.Val.Value == DXW.OnOffOnlyValues.On)
      return OnOffToggle.On;
    if (openXmlElement.Val.Value == DXW.OnOffOnlyValues.Off)
      return OnOffToggle.Off;

    return OnOffToggle.Toggle;
  }

  /// <summary>
  /// Creates a new instance of the specified OnOffOnlyType and sets its value to the provided OnOffToggle value.
  /// </summary>
  /// <param name="value">The OnOffToggle value to create the OnOffOnlyType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXW.OnOffOnlyType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  private static DXW.OnOffOnlyType? ConvertToOnOffOnlyType(OnOffToggle? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DXW.OnOffOnlyType)Activator.CreateInstance(targetType)!;
    if (value == OnOffToggle.On)
      element.Val = DXW.OnOffOnlyValues.On;
    else if (value == OnOffToggle.Off)
      element.Val = DXW.OnOffOnlyValues.Off;

    return element;
  }

  #endregion

  #region Office2010 Word OnOffValues conversion.

  /// <summary>
  /// Retrieves a OnOffToggle openXmlElement from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The OnOffValues to get OnOffToggle openXmlElement.</param>
  /// <returns>True for True/One, false for False/Zero.</returns>
  private static OnOffToggle? ConvertFromO10WOnOffValues(DXO10W.OnOffValues? openXmlElement)
  {
    if (openXmlElement == null) return null;
    if (openXmlElement == DXO10W.OnOffValues.True || openXmlElement == DXO10W.OnOffValues.One)
      return OnOffToggle.On;
    if (openXmlElement == DXO10W.OnOffValues.False || openXmlElement == DXO10W.OnOffValues.Zero)
      return OnOffToggle.Off;

    return OnOffToggle.Toggle;
  }

  /// <summary>
  /// Converts a nullable OnOffToggle value to its corresponding Open XML OnOffValues enumeration value.
  /// </summary>
  /// <param name="value">The nullable OnOffToggle value to convert. If <see langword="true"/>, returns <c>OnOffValues.One</c>; if <see
  /// langword="false"/>, returns <c>OnOffValues.Zero</c>; if <see langword="null"/>, returns <see langword="null"/>.</param>
  /// <returns>A <c>DXO10W.OnOffValues</c> value representing the OnOffToggle input.</returns>
  private static DXO10W.OnOffValues? ConvertToO10WOnOffValues(OnOffToggle? value)
  {
    if (value == null) return null;
    if (value == OnOffToggle.On)
      return DXO10W.OnOffValues.One;
    if (value == OnOffToggle.Off)
      return DXO10W.OnOffValues.Zero;

    return null;
  }

  #endregion

  #region EnumValue of Office2010 Word OnOffValues conversion.

  /// <summary>
  /// Retrieves a OnOffToggle value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  private static OnOffToggle? ConvertFromEnumValueOfO10WOnOffValues(DX.EnumValue<DXO10W.OnOffValues>? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var value = openXmlElement.Value;
    if (value == DXO10W.OnOffValues.True || value == DXO10W.OnOffValues.One)
      return OnOffToggle.On;
    if (value == DXO10W.OnOffValues.False || value == DXO10W.OnOffValues.Zero)
      return OnOffToggle.Off;

    return null;
  }

  /// <summary>
  /// Converts a OnOffToggle value to enum value of Office2010 Word OnOffValue.
  /// </summary>
  /// <param name="value">The OnOffToggle value to convert.</param>
  /// <returns>An <see cref="DXO10W.OnOffValues"/> corresponding to the specified OnOffToggle value, or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  private static DX.EnumValue<DXO10W.OnOffValues>? ConvertToEnumValueOfO10WOnOffValues(OnOffToggle? value)
  {
    if (value == null) return null;

    if (value == OnOffToggle.On)
      return new DX.EnumValue<DXO10W.OnOffValues>(DXO10W.OnOffValues.One);
    if (value == OnOffToggle.Off)
      return new DX.EnumValue<DXO10W.OnOffValues>(DXO10W.OnOffValues.Zero);
    else
      return null;
  }

  #endregion

  #region Office2010 Word OnOffType conversion.

  /// <summary>
  /// Retrieves a OnOffToggle value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero.</returns>
  private static OnOffToggle? ConvertFromO10WOnOffType(DXO10W.OnOffType? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var value = openXmlElement.Val?.Value;
    if (value == DXO10W.OnOffValues.True || value == DXO10W.OnOffValues.One)
      return OnOffToggle.On;
    if (value == DXO10W.OnOffValues.False || value == DXO10W.OnOffValues.Zero)
      return OnOffToggle.Off;

    return null;
  }

  /// <summary>
  /// Creates a new instance of the specified OnOffType and sets its value to the provided OnOffToggle value.
  /// </summary>
  /// <param name="value">The OnOffToggle value to create the OnOffType element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OnOffType to instantiate. Must be a type derived from DXW.OnOffType.</param>
  /// <returns>A new instance of the specified OnOffType with its value set to <paramref name="value"/>.</returns>
  private static DXO10W.OnOffType? ConvertToO10WOnOffType(OnOffToggle? value, Type targetType)
  {
    if (value == null) return null;

    if (targetType.GetConstructor([typeof(bool)]) != null)
    {
      if (value == OnOffToggle.On)
        return (DXO10W.OnOffType)Activator.CreateInstance(targetType, true)!;
      if (value == OnOffToggle.Off)
        return (DXO10W.OnOffType)Activator.CreateInstance(targetType, false)!;

      return null;
    }
    var element = (DXO10W.OnOffType)Activator.CreateInstance(targetType)!;
    if (value == OnOffToggle.On)
      element.Val = new DX.EnumValue<DXO10W.OnOffValues>(DXO10W.OnOffValues.One);
    if (value == OnOffToggle.Off)
      element.Val = new DX.EnumValue<DXO10W.OnOffValues>(DXO10W.OnOffValues.Zero);

    return element;
  }

  #endregion

  #region OnOffValue conversion.

  /// <summary>
  /// Retrieves a OnOffToggle openXmlElement from the specified OnOffValue comparable simple openXmlElement.
  /// </summary>
  /// <param name="openXmlElement">The openXmlElement to convert</param>
  /// <returns>True for True/On/One, false for False/Off/Zero, or null.</returns>
  private static OnOffToggle? ConvertFromBooleanValue(DX.BooleanValue? openXmlElement)
  {
    if (openXmlElement == null) return null;

    if (openXmlElement)
      return OnOffToggle.On;
    else
      return OnOffToggle.Off;
  }

  /// <summary>
  /// Converts a nullable OnOffToggle value to its corresponding OpenXml OnOffValue representation.
  /// </summary>
  /// <param name="value">The nullable OnOffToggle value to convert. If null, the method returns null.</param>
  /// <returns>A DX.OnOffValue value representing the OnOffToggle input</returns>
  private static DX.BooleanValue? ConvertToBooleanValue(OnOffToggle? value)
  {
    if (value == null) return null;
    if (value == OnOffToggle.On)
      return new DX.BooleanValue(true);
    if (value == OnOffToggle.Off)
      return new DX.BooleanValue(false);
    return null;
  }

  #endregion

  #region OnOffValue conversion.

  /// <summary>
  /// Retrieves a OnOffToggle openXmlElement from the specified OnOffValue comparable simple openXmlElement.
  /// </summary>
  /// <param name="openXmlElement">The openXmlElement to convert</param>
  /// <returns>True for True/On/One, false for False/Off/Zero, or null.</returns>
  private static OnOffToggle? ConvertFromOnOffValue(DX.OnOffValue? openXmlElement)
  {
    if (openXmlElement == null) return null;

    if (openXmlElement)
      return OnOffToggle.On;
    else
      return OnOffToggle.Off;
  }

  /// <summary>
  /// Converts a nullable OnOffToggle value to its corresponding OpenXml OnOffValue representation.
  /// </summary>
  /// <param name="value">The nullable OnOffToggle value to convert. If null, the method returns null.</param>
  /// <returns>A DX.OnOffValue value representing the OnOffToggle input</returns>
  private static DX.OnOffValue? ConvertToOnOffValue(OnOffToggle? value)
  {
    if (value == null) return null;
    if (value == OnOffToggle.On)
      return new DX.OnOffValue(true);
    if (value == OnOffToggle.Off)
      return new DX.OnOffValue(false);
    return null;
  }

  #endregion

  #region Math OnOffValues conversion.

  /// <summary>
  /// Retrieves a OnOffToggle openXmlElement from the specified Math OnOffValues enum openXmlElement.
  /// </summary>
  /// <param name="openXmlElement">The openXmlElement to convert</param>
  /// <returns>True for True/On/One, false for False/Off/Zero, or null.</returns>
  private static OnOffToggle? ConvertFromBooleanValues(DXM.BooleanValues? openXmlElement)
  {
    if (openXmlElement == null) return null;
    if (openXmlElement == DXM.BooleanValues.True || openXmlElement == DXM.BooleanValues.On || openXmlElement == DXM.BooleanValues.One)
      return OnOffToggle.On;
    if (openXmlElement == DXM.BooleanValues.False || openXmlElement == DXM.BooleanValues.Off || openXmlElement == DXM.BooleanValues.Zero)
      return OnOffToggle.Off;

    return OnOffToggle.Toggle;
  }

  /// <summary>
  /// Converts a nullable OnOffToggle value to its corresponding OpenXml Math OnOffValues representation.
  /// </summary>
  /// <param name="value">The nullable OnOffToggle value to convert. If null, the method returns null.</param>
  /// <returns>A DXM.BooleanValues value representing the OnOffToggle input: DXM.BooleanValues.One if <paramref name="value"/> is
  /// <see langword="true"/>, DXM.BooleanValues.Zero if <paramref name="value"/> is <see langword="false"/>, or null if
  /// <paramref name="value"/> is null.</returns>
  private static DXM.BooleanValues? ConvertToBooleanValues(OnOffToggle? value)
  {
    if (value == null) return null;

    if (value == OnOffToggle.On)
      return DXM.BooleanValues.One;
    if (value == OnOffToggle.Off)
      return DXM.BooleanValues.Zero;
    return null;
  }

  #endregion

  #region EnumValue of Office2010 Word OnOffValues conversion.

  /// <summary>
  /// Retrieves a OnOffToggle value from the specified Word 2010 OnOffValue.
  /// </summary>
  /// <param name="openXmlElement">The EnumValue of OnOffValues to check.</param>
  /// <returns>True for True/One, false for False/Zero, or null.</returns>
  private static OnOffToggle? ConvertFromEnumValueOfOnOffValues(DX.EnumValue<DXM.BooleanValues>? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var value = openXmlElement.Value;
    if (value == DXM.BooleanValues.True || value == DXM.BooleanValues.On || value == DXM.BooleanValues.One)
      return OnOffToggle.On;
    if (value == DXM.BooleanValues.False || value == DXM.BooleanValues.Off || value == DXM.BooleanValues.Zero)
      return OnOffToggle.Off;

    return OnOffToggle.Toggle;
  }

  /// <summary>
  /// Converts a OnOffToggle value to enum value of Office2010 Word OnOffValue.
  /// </summary>
  /// <param name="value">The OnOffToggle value to convert.</param>
  /// <returns>An <see cref="DXO10W.OnOffValues"/> corresponding to the specified OnOffToggle value, or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  private static DX.EnumValue<DXM.BooleanValues>? ConvertToEnumValueOfOnOffValues(OnOffToggle? value)
  {
    if (value == null) return null;

    if (value == OnOffToggle.On)
      return new DX.EnumValue<DXM.BooleanValues>(DXM.BooleanValues.One);
    if (value == OnOffToggle.Off)
      return new DX.EnumValue<DXM.BooleanValues>(DXM.BooleanValues.Zero);

    return null;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Retrieves a OnOffToggle value from the text content of a OpenXmlLeafTextElement element.
  /// </summary>
  /// <param name="element">The OpenXmlLeafTextElement to check.</param>
  /// <returns>True for "true" or "1", false for "false" or "0", or null.</returns>
  private static OnOffToggle? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? element)
  {
    if (element == null) return null;


    var text = element.Text.ToLower();
    switch (text)
    {
      case "": return OnOffToggle.Toggle;
      case "true": return OnOffToggle.On;
      case "false": return OnOffToggle.Off;
      case "1": return OnOffToggle.On;
      case "0": return OnOffToggle.Off;
    }
    return OnOffToggle.Undefined;
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElement with text content "1" or "0" based on the OnOffToggle value.
  /// </summary>
  /// <param name="value">The OnOffToggle value to convert.</param>
  /// <param name="targetType">The type of the element to create.</param>
  /// <returns>A new element with content "1" or "0".</returns>
  private static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(OnOffToggle? value, Type targetType)
  {
    if (value == null) return null;

    var element = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(targetType)!;
    if (value == OnOffToggle.On)
    {
      element.Text = "1";
    }
    else if (value == OnOffToggle.Off)
    {
      element.Text = "0";
    }
    return element;
  }

  #endregion

  #region DXW.OpenXmlLeafElement conversion.

  /// <summary>
  /// Retrieves a OnOffToggle value from the specified DX.OpenXmlLeafElement element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlLeafElement to check.</param>
  /// <returns>The OnOffToggle value, true if element exists but value is null.</returns>
  private static OnOffToggle? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? openXmlElement)
  {
    if (openXmlElement == null) return null;

    var valProp = openXmlElement.GetType().GetProperty("Val");
    if (valProp == null)
      throw new InvalidOperationException("The Val property is not found in " + openXmlElement.GetType().Name);

    var valValue = valProp.GetValue(openXmlElement);
    return ConvertFrom(valValue);
  }

  /// <summary>
  /// Creates a new instance of the specified DX.OpenXmlLeafElement and sets its value to the provided OnOffToggle value.
  /// </summary>
  /// <param name="value">The OnOffToggle value to create the OpenXmlLeafElement element. If <see langword="null"/>, the method returns <see
  /// langword="null"/>.</param>
  /// <param name="targetType">The type of OpenXmlLeafElement to instantiate. Must be a type derived from DX.OpenXmlLeafElement.</param>
  /// <returns>A new instance of the specified OpenXmlLeafElement with its value set to <paramref name="value"/>; or <see
  /// langword="null"/> if <paramref name="value"/> is <see langword="null"/>.</returns>
  private static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(OnOffToggle? value, Type targetType)
  {
    if (value == null) return null;
    if (targetType.GetConstructor([typeof(OnOffToggle)]) != null)
      return (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType, value)!;

    var element = (DX.OpenXmlLeafElement)Activator.CreateInstance(targetType)!;
    var valProp = targetType.GetValProperty();
    if (valProp == null)
      throw new InvalidOperationException("The Val property is not found in " + targetType.Name);

    var valValue = StaticTypeConverter.ChangeType(value, valProp.PropertyType);
    valProp.SetValue(element, valValue);
    return element;
  }

  #endregion

  #region string conversion.

  /// <summary>
  /// Parses textual representations of a tri-state boolean (true/false/blank) into <see cref="OnOffToggle"/>.
  /// </summary>
  /// <param name="value">The string to interpret. Null or unrecognized text yields <see cref="OnOffToggle.Toggle"/>.</param>
  /// <returns>The parsed <see cref="OnOffToggle"/> value.</returns>
  public static OnOffToggle OnOffToggleFromString(string? value)
  {
    if (value == null)
      return OnOffToggle.Toggle;

    value = value.ToLower();
    if (value == "true" || value == "1")
      return OnOffToggle.On;
    if (value == "false" || value == "0")
      return OnOffToggle.Off;

    return OnOffToggle.Toggle;
  }

  /// <summary>
  /// Serializes a <see cref="OnOffToggle"/> into a human-readable token.
  /// </summary>
  /// <param name="value">The tri-state value to serialize.</param>
  /// <returns>"true", "false", or "blank" according to <paramref name="value"/>.</returns>
  public static string OnOffToggleToString(OnOffToggle value)
  {
    if (value == OnOffToggle.On)
      return "true";
    if (value == OnOffToggle.Off)
      return "false";

    return "toggle";
  }

  #endregion

  #region Generic OpenXml three-state boolean converter

  /// <summary>
  /// Converts the specified <see cref="OnOffToggle"/> value to the specified target type, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The tri-state source value.</param>
  /// <param name="targetType">The desired Open XML target type.</param>
  /// <returns>The converted object suitable for the specified target type.</returns>
  /// <exception cref="NotSupportedException">Thrown when no converter exists for <paramref name="targetType"/>.</exception>
  public static object? ConvertTo(OnOffToggle? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value to a <see cref="OnOffToggle"/> instance, if a supported conversion exists. 
  /// </summary>
  /// <param name="value">The value to convert to <see cref="OnOffToggle"/>. Can be <see langword="null"/>.</param>
  /// <returns>A <see cref="OnOffToggle"/> representation of the specified value, or <see langword="null"/> if <paramref
  /// name="value"/> is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> to <see cref="OnOffToggle"/> is not supported.</exception>
  public static OnOffToggle? ConvertFrom(object? value)
  {
    return (OnOffToggle?)ConverterBase.ConvertFrom(value, typeof(OnOffToggle), ConversionFromMap);
  }

  #endregion
}