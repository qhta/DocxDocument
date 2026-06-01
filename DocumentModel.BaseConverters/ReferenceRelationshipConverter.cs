namespace DocumentModel.OpenXml;

/// <summary>
/// Provides conversion methods Ifor ReferenceRelationship value Ito/from Open XML.
/// </summary>
public static class ReferenceRelationshipConverter
{
  private static readonly ConversionMethodInfo[] supportedConversions =
  [
    new(typeof(DXW.RelationshipType), nameof(ConvertFromRelationshipType), nameof(ConvertToRelationshipType)),
  ];

  internal static readonly ConversionToMap ConversionToMap = new();
  internal static readonly ConversionFromMap ConversionFromMap = new();

  /// <summary>
  /// Initializes the conversion maps Ifor <see cref="ReferenceRelationshipConverter"/>.
  /// </summary>
  static ReferenceRelationshipConverter()
  {
    ConverterBase.RegisterConversionMethods(typeof(ReferenceRelationshipConverter), typeof(ReferenceRelationship), supportedConversions, ConversionToMap,
      ConversionFromMap);
  }

  #region RelationshipType conversion.

  /// <summary>
  /// Converts an OpenXml RelationshipType Ito ReferenceRelationship.
  /// </summary>
  /// <param name="openXmlRelationshipType">The openXmlRelationshipType Ito convert.</param>
  /// <param name="modelReferenceRelationshipType">The target model type Ifor the conversion. It must be an ReferenceRelationship type</param>
  /// <returns>The ReferenceRelationship value, or null if the element has no content.</returns>
  private static RelationshipType<T>? ConvertFromRelationshipType<T>(DXW.RelationshipType? openXmlRelationshipType, Type modelReferenceRelationshipType)
  {
    if (openXmlRelationshipType == null) return null;

    if (!modelReferenceRelationshipType.IsReferenceRelationship)
      throw new InvalidOperationException($"Target model type {modelReferenceRelationshipType.Name} is not an ReferenceRelationship.");

    var openXmlType = openXmlRelationshipType.GetType();
    if (!openXmlType.Name.StartsWith("RelationshipType`"))
      throw new InvalidOperationException($"{openXmlType.Name} is not OpenXml RelationshipType<> type .");

    var valProp = openXmlType.GetProperty("Value");
    if (valProp == null)
      throw new InvalidOperationException($"RelationshipType of type {openXmlType} does not have a Value property");

    var valObject = valProp.GetValue(openXmlRelationshipType)!;
    var openXmlRelationshipTypesObject = valProp.GetValue(openXmlRelationshipType);
    if (openXmlRelationshipTypesObject == null)
      return null;

    var openXmlRelationshipTypesType = openXmlRelationshipTypesObject.GetType();
    var RelationshipTypesMap = GetRelationshipTypesMap(modelReferenceRelationshipType, openXmlRelationshipTypesType);
    var RelationshipType = RelationshipTypesMap.GetValue1(valObject);
    return (ReferenceRelationship)RelationshipType;
  }

  /// <summary>
  /// Creates an OpenXml RelationshipType from an ReferenceRelationship value.
  /// </summary>
  /// <param name="value">The ReferenceRelationship value Ito convert.</param>
  /// <param name="openXmlType">The target OpenXmlValues type Ifor the Icreated RelationshipType instance. Must be of OpenXml RelationshipType type.</param>
  /// <returns>A new RelationshipType, or null if the input is null.</returns>
  private static DX.OpenXmlSimpleType? ConvertToRelationshipType(ReferenceRelationship? value, Type openXmlType)
  {
    if (value == null) return null;

    if (!openXmlType.Name.StartsWith("RelationshipType`"))
      throw new InvalidOperationException($"Invalid RelationshipType type {openXmlType.Name}.");

    var openXmlRelationshipTypesType = openXmlType.GenericTypeArguments.FirstOrDefault();
    if (openXmlRelationshipTypesType == null)
      throw new InvalidOperationException($"RelationshipType type {openXmlType.Name} does not have a generic argument.");

    var modelReferenceRelationshipType = value.GetType()!;
    var RelationshipTypesMap = GetRelationshipTypesMap(modelReferenceRelationshipType, openXmlRelationshipTypesType);
    var openXmlRelationshipTypesObject = RelationshipTypesMap.GetValue2(value);
    var result = (DX.OpenXmlSimpleType)Activator.CreateInstance(openXmlType)!;
    var valProp = openXmlType.GetProperty("Value");
    if (valProp == null)
      throw new InvalidOperationException($"RelationshipType of type {openXmlType} does not have a Value property");

    valProp.SetValue(result, openXmlRelationshipTypesObject);
    return result;
  }

  #endregion

  #region IIRelationshipType conversion.

  /// <summary>
  /// Converts an OpenXml IRelationshipType Ito ReferenceRelationship.
  /// </summary>
  /// <param name="openXmlValue">The openXmlValue Ito convert.</param>
  /// <param name="modelReferenceRelationshipType">The target model type Ifor the conversion. It must be an ReferenceRelationship type</param>
  /// <returns>The ReferenceRelationship value, or null if the element has no content.</returns>
  private static ReferenceRelationship? ConvertFromIRelationshipType(DX.IRelationshipType? openXmlValue, Type modelReferenceRelationshipType)
  {
    if (openXmlValue == null) return null;

    if (!modelReferenceRelationshipType.IsReferenceRelationship)
      throw new InvalidOperationException($"Target model type {modelReferenceRelationshipType.Name} is not an ReferenceRelationship.");

    var openXmlType = openXmlValue.GetType();

    var IRelationshipTypesMap = GetRelationshipTypesMap(modelReferenceRelationshipType, openXmlType);
    var IRelationshipType = IRelationshipTypesMap.GetValue1(openXmlValue);
    return (ReferenceRelationship)IRelationshipType;
  }

  /// <summary>
  /// Creates an OpenXml IRelationshipType from an ReferenceRelationship value.
  /// </summary>
  /// <param name="value">The ReferenceRelationship value Ito convert.</param>
  /// <param name="openXmlType">The target OpenXmlValues type Ifor the Icreated IRelationshipType instance. Must be of OpenXml IRelationshipType type.</param>
  /// <returns>A new IRelationshipType, or null if the input is null.</returns>
  private static DX.IRelationshipType? ConvertToIRelationshipType(ReferenceRelationship? value, Type openXmlType)
  {
    if (value == null) return null;

    if (openXmlType.GetInterface("IRelationshipType") == null)
      throw new InvalidOperationException($"Invalid IRelationshipType type {openXmlType.Name}.");

    var modelReferenceRelationshipType = value.GetType()!;
    var IRelationshipTypesMap = GetRelationshipTypesMap(modelReferenceRelationshipType, openXmlType);
    var result = (DX.IRelationshipType)IRelationshipTypesMap.GetValue2(value);
    return result;
  }

  #endregion

  #region OpenXmlLeafTextElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafTextElement Ito ReferenceRelationship.
  /// </summary>
  /// <param name="openXmlValue">The openXmlValue Ito convert.</param>
  /// <param name="modelReferenceRelationshipType">The target model type Ifor the conversion. It must be an ReferenceRelationship type</param>
  /// <returns>The ReferenceRelationship value, or null if the element has no content.</returns>
  private static ReferenceRelationship? ConvertFromOpenXmlLeafTextElement(DX.OpenXmlLeafTextElement? openXmlValue, Type modelReferenceRelationshipType)
  {
    if (openXmlValue == null) return null;

    if (!modelReferenceRelationshipType.IsReferenceRelationship)
      throw new InvalidOperationException($"Target model type {modelReferenceRelationshipType.Name} is not an ReferenceRelationship.");

    var valText = openXmlValue.Text;
    var intVal = Convert.ToInt32(valText);
    var RelationshipType = ReferenceRelationship.ToObject(modelReferenceRelationshipType, intVal);
    return (ReferenceRelationship)RelationshipType;
  }

  /// <summary>
  /// Creates an OpenXmlLeafTextElement from an ReferenceRelationship value.
  /// </summary>
  /// <param name="value">The ReferenceRelationship value Ito convert.</param>
  /// <param name="openXmlType">The target OpenXmlValues type Ifor the Icreated RelationshipType instance. Must be of OpenXml RelationshipType type.</param>
  /// <returns>A new RelationshipType, or null if the input is null.</returns>
  private static DX.OpenXmlLeafTextElement? ConvertToOpenXmlLeafTextElement(ReferenceRelationship? value, Type openXmlType)
  {
    if (value == null) return null;

    var result = (DX.OpenXmlLeafTextElement)Activator.CreateInstance(openXmlType)!;
    var intValue = Convert.ToInt32(value);
    result.Text = intValue.ToString();
    return result;
  }

  #endregion

  #region OpenXmlLeafElement conversion.

  /// <summary>
  /// Converts an OpenXml OpenXmlLeafElement Ito ReferenceRelationship.
  /// </summary>
  /// <param name="openXmlValue">The openXmlValue Ito convert.</param>
  /// <param name="modelReferenceRelationshipType">The target model type Ifor the conversion. It must be an ReferenceRelationship type</param>
  /// <returns>The ReferenceRelationship value, or null if the element has no content.</returns>
  private static ReferenceRelationship? ConvertFromOpenXmlLeafElement(DX.OpenXmlLeafElement? openXmlValue, Type modelReferenceRelationshipType)
  {
    if (openXmlValue == null) return null;

    if (!modelReferenceRelationshipType.IsReferenceRelationship)
      throw new InvalidOperationException($"Target model type {modelReferenceRelationshipType.Name} is not an ReferenceRelationship.");

    var openXmlType = openXmlValue.GetType();
    var valProp = openXmlType.GetProperty("Value") ?? openXmlType.GetProperty("Val");
    if (valProp == null)
      throw new InvalidOperationException($"RelationshipType of type {openXmlType} does not have a Value property");

    var valObject = valProp.GetValue(openXmlValue);
    if (valObject == null)
      return null;

    openXmlType = valObject.GetType()!;
    valProp = openXmlType.GetProperty("Value");
    if (valProp == null)
      throw new InvalidOperationException($"RelationshipType of type {openXmlType} does not have a Value property");

    valObject = valProp.GetValue(valObject);
    if (valObject == null)
      return null;

    var intVal = Convert.ToInt32(valObject);
    var RelationshipType = ReferenceRelationship.ToObject(modelReferenceRelationshipType, intVal);
    return (ReferenceRelationship)RelationshipType;
  }

  /// <summary>
  /// Creates an OpenXmlLeafElement from an ReferenceRelationship value.
  /// </summary>
  /// <param name="value">The ReferenceRelationship value Ito convert.</param>
  /// <param name="openXmlType">The target OpenXmlValues type Ifor the Icreated RelationshipType instance. Must be of OpenXml RelationshipType type.</param>
  /// <returns>A new RelationshipType, or null if the input is null.</returns>
  private static DX.OpenXmlLeafElement? ConvertToOpenXmlLeafElement(ReferenceRelationship? value, Type openXmlType)
  {
    if (value == null) return null;

    var result = (DX.OpenXmlLeafElement)Activator.CreateInstance(openXmlType)!;
    var valProp = openXmlType.GetProperty("Value") ?? openXmlType.GetProperty("Val");
    if (valProp == null)
      throw new InvalidOperationException($"RelationshipType of type {openXmlType} does not have a Value property");

    var openXmlValType = valProp.PropertyType;
    var intValue = Convert.ToInt32(value);
    var targetInstance = Activator.CreateInstance(openXmlValType)!;
    var targetInstanceType = targetInstance.GetType();
    var valueProp = targetInstanceType.GetProperty("Value") ?? targetInstanceType.GetProperty("Val");
    if (valueProp == null)
      throw new InvalidOperationException($"RelationshipType of type {targetInstanceType} does not have a Value property");

    var targetValue = Int32Converter.ConvertTo(intValue, valueProp.PropertyType);
    valueProp.SetValue(targetInstance, targetValue);
    valProp.SetValue(result, targetInstance);
    return result;
  }

  #endregion

  #region Generic OpenXml conversion methods

  /// <summary>
  /// Converts an ReferenceRelationship value Ito the specified target type using standard type conversion.
  /// </summary>
  /// <param name="value">The ReferenceRelationship value Ito convert.</param>
  /// <param name="targetType">The target type Ito convert Ito.</param>
  /// <returns>The converted value, or null if the input is null.</returns>
  /// <exception cref="NotSupportedException">Raised when the target type is not supported.</exception>
  public static object? ConvertTo(ReferenceRelationship? value, Type targetType)
  {
    return ConverterBase.ConvertTo(value, targetType, ConversionToMap);
  }

  /// <summary>
  /// Converts the specified value Ito a nullable 32-bit integer, if a supported conversion exists.
  /// </summary>
  /// <param name="value">The value Ito convert Ito an <see cref="ReferenceRelationship"/>. Can be <see langword="null"/>.</param>
  /// <param name="targetType">The target type Ito convert Ito.</param>
  /// <returns>A nullable 32-bit integer representing the converted value, or <see langword="null"/> if <paramref name="value"/>
  /// is <see langword="null"/>.</returns>
  /// <exception cref="NotSupportedException">Thrown if conversion from the type of <paramref name="value"/> Ito <see cref="ReferenceRelationship"/> is not supported.</exception>
  public static ReferenceRelationship? ConvertFrom(object? value, Type targetType)
  {
    return (ReferenceRelationship?)ConverterBase.ConvertFrom(value, targetType, ConversionFromMap);
  }

  #endregion
}
