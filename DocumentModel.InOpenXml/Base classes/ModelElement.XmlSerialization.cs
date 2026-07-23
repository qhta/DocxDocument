using System.Security.AccessControl;

using Qhta.Conversion;

namespace DocumentModel;

/// <summary>
/// Provides XML serialization support for the <see cref="DocumentProperty"/> class.
/// </summary>
public partial class ModelElement : IXmlSerializable
{
  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;

  private static void RegisterStringConverters()
  {
    TypeToStringConverter.RegisterType(typeof(DateTime));
  }

  /// <summary>
  /// Reads the XML representation of the current instance from the specified <see cref="XmlReader"/>.
  /// </summary>
  /// <param name="reader"></param>
  public virtual void ReadXml(XmlReader reader)
  {
    reader.MoveToContent();

    var serializableProperties = GetSerializableProperties();

    // Read attributes
    ReadAttributes(reader, serializableProperties);

    var isEmptyElement = reader.IsEmptyElement;
    reader.ReadStartElement();
    if (isEmptyElement)
      return;

    reader.MoveToContent();

    // Read child elements serialized as properties.
    ReadProperties(reader, serializableProperties);

    // Read remaining child elements serialized as collection items.
    ReadItems(reader);
    if (reader.NodeType == XmlNodeType.EndElement)
      reader.ReadEndElement();
  }

  /// <summary>
  /// Reads the attributes of the current XML element and sets the corresponding properties of the current instance.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> from which the XML representation of the attributes will be read.</param>
  /// <param name="serializableProperties">An array of <see cref="PropertyInfo"/> objects representing the properties to be read from the XML attributes.</param>
  protected virtual void ReadAttributes(XmlReader reader, PropertyInfo[] serializableProperties)
  {
    if (reader.NodeType == XmlNodeType.Element && reader.MoveToFirstAttribute())
    {
      do
      {
        var propName = reader.LocalName;
        var propValue = reader.Value;
        var property =
          serializableProperties.FirstOrDefault(p => p.Name.Equals(propName, StringComparison.OrdinalIgnoreCase));
        if (property != null && property.CanWrite)
        {
          var valueType = property.PropertyType.GetNotNullableType();
          var value = ObjectToStringConverter.ConvertFromString(propValue, valueType);
          property.SetValue(this, value);
        }
      } while (reader.MoveToNextAttribute());

      reader.MoveToElement();
    }
  }

  /// <summary>
  /// Reads the child elements of the current XML element and sets the corresponding properties of the current instance.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> from which the XML representation of the properties will be read.</param>
  /// <param name="elementProperties">An array of <see cref="PropertyInfo"/> objects representing the properties to be read from the XML.</param>
  protected virtual void ReadProperties(XmlReader reader, PropertyInfo[] elementProperties)
  {
    while (reader.NodeType == XmlNodeType.Element)
    {
      var propName = reader.LocalName;
      var property = elementProperties.FirstOrDefault(p => p.Name.Equals(propName, StringComparison.OrdinalIgnoreCase));
      if (property == null)
        break;

      var propertyType = property.PropertyType.GetNotNullableType();
      if (property.CanWrite)
      {
        var value = property.GetValue(this) ?? Activator.CreateInstance(propertyType);
        if (value is IXmlSerializable xmlSerializable)
        {
          xmlSerializable.ReadXml(reader);
          property.SetValue(this, value);
        }
        else
        {
          reader.Skip();
        }
      }
      else
      {
        var value = property.GetValue(this);
        if (value is IXmlSerializable xmlSerializable)
          xmlSerializable.ReadXml(reader);
        else
          reader.Skip();
      }
    }
    reader.MoveToContent();
  }

  /// <summary>
  /// Reads the child elements of the current XML element and adds them to the current instance using the appropriate "Add" method.
  /// </summary>
  /// <param name="reader">The <see cref="XmlReader"/> from which the XML representation of the items will be read.</param>
  /// <exception cref="ApplicationException">Thrown when no suitable Add method is found for a given type.</exception>
  protected virtual void ReadItems(XmlReader reader)
  {
    var thisType = this.GetType();
    var addMethods = thisType.GetMethods(BindingFlags.Public | BindingFlags.Instance)
      .Where(m => m.Name.StartsWith("Add") && m.GetParameters().Length == 1).ToArray();

    while (reader.NodeType == XmlNodeType.Element)
    {
      var elementName = reader.LocalName;
      var elementType = XmlSerializationHelper.ResolveType(elementName, this.GetType().Namespace!);
      var item = Activator.CreateInstance(elementType);
      if (item is IXmlSerializable xmlSerializable)
      {
        xmlSerializable.ReadXml(reader);
        var addMethod =
          addMethods.FirstOrDefault(m => m.GetParameters()[0].ParameterType.IsAssignableFrom(elementType));
        if (addMethod != null)
        {
          addMethod.Invoke(this, [item]);
        }
        else
        {
          throw new ApplicationException($"No suitable Add method found for type {elementType.FullName}");
        }
      }
      else
      {
        throw new ApplicationException($"Item of type {elementType.FullName} does not implement IXmlSerializable");
      }
    }
  }

  /// <summary>
  /// Writes the XML representation of the current instance to the specified <see cref="XmlWriter"/>.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to which the XML representation of the current instance will be written.</param>
  public virtual void WriteXml(XmlWriter writer)
  {
    var serializableProperties = GetSerializableProperties();
    var (attributeProperties, elementProperties) = serializableProperties.SplitAttributesAndElements();
    WriteAttributes(writer, attributeProperties, out var extraElementProperties);
    WriteProperties(writer, elementProperties.Concat(extraElementProperties).ToArray());
    WriteItems(writer);
  }

  /// <summary>
  /// Writes the attributes of the current instance to the specified <see cref="XmlWriter"/>.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to which the XML representation of the attributes will be written.</param>
  /// <param name="attributeProperties">An array of <see cref="PropertyInfo"/> objects representing the properties to be written as attributes.</param>
  /// <param name="extraElementProperties">An array of <see cref="PropertyInfo"/> objects representing the properties to be written as child elements.</param>
  protected virtual void WriteAttributes(XmlWriter writer, PropertyInfo[] attributeProperties, out PropertyInfo[] extraElementProperties)
  {
    List<PropertyInfo> extraElements = new List<PropertyInfo>();
    try
    {
      foreach (var property in attributeProperties)
      {
        var value = property.GetValue(this);
        if (value != null)
        {
          var valueType = value.GetType();

          TypeToStringConverter.RegisterType(valueType);
          string? valueString = ObjectToStringConverter.ConvertToString(value);
          if (valueString != null)
            writer.WriteAttributeString(property.Name.ToLowerFirst(), valueString);
          else
            extraElements.Add(property);
        }
      }
      extraElementProperties = extraElements.ToArray();
    }
    catch (Exception ex)
    {
      Debug.WriteLine(ex);
      throw;
    }
  }

  /// <summary>
  /// Writes the properties of the current instance to the specified <see cref="XmlWriter"/> as child elements.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to which the XML representation of the properties will be written.</param>
  /// <param name="elementProperties">An array of <see cref="PropertyInfo"/> objects representing the properties to be written as child elements.</param>
  protected virtual void WriteProperties(XmlWriter writer, PropertyInfo[] elementProperties)
  {
    if (elementProperties.Any())
    {
      foreach (var property in elementProperties)
      {
        var value = property.GetValue(this);
        if (value != null)
        {
          string? elementName = null;
          if (property.GetCustomAttribute<XmlElementAttribute>() is XmlElementAttribute xmlElementAttribute)
          {
            elementName = xmlElementAttribute.ElementName;
          }
          else if (property.GetCustomAttribute<XmlArrayAttribute>() is XmlArrayAttribute xmlArrayAttribute)
          {
            elementName = xmlArrayAttribute.ElementName;
          }
          else
          {
            elementName = property.Name.ToLowerFirst();
          }
          if (string.IsNullOrEmpty(elementName))
          {
            if (value is IXmlSerializable xmlSerializable)
            {
              xmlSerializable.WriteXml(writer);
            }
          }
          else
          {
            writer.WriteStartElement(elementName);
            if (value is IXmlSerializable xmlSerializable)
            {
              xmlSerializable.WriteXml(writer);
            }
            writer.WriteEndElement();
          }
        }
      }
    }
  }

  /// <summary>
  /// Writes the child elements of the current instance to the specified <see cref="XmlWriter"/>.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to which the XML representation of the child elements will be written.</param>
  protected virtual void WriteItems(XmlWriter writer)
  {
    if (this is IEnumerable enumerable)
    {
      foreach (var item in enumerable)
      {
        var itemType = item.GetType();
        if (item is IXmlSerializable xmlSerializable)
        {

          writer.WriteStartElement(itemType.Name);
          xmlSerializable.WriteXml(writer);
          writer.WriteEndElement();
        }
      }
    }
  }

  /// <summary>
  /// Gets the properties of the current instance that should be serialized to XML.
  /// </summary>
  /// <returns>An array of <see cref="PropertyInfo"/> objects representing the serializable properties.</returns>
  protected virtual PropertyInfo[] GetSerializableProperties() => this.GetType().GetSerializableProperties();


}

/// <summary>
/// Provides utility methods for XML serialization
/// </summary>
public static class XmlSerializationTool
{
  private static readonly Dictionary<Type, PropertyInfo[]>
    _serializablePropertiesCache = new Dictionary<Type, PropertyInfo[]>();
  private static readonly Dictionary<PropertyInfo[], (PropertyInfo[] attributeProperties, PropertyInfo[] elementProperties)>
    _splitPropertiesCache = new();

  /// <summary>
  /// Static method that retrieves the properties of a given type that should be serialized to XML. It filters out properties that are not readable, not writable, or marked with the <see cref="XmlIgnoreAttribute"/>.
  /// </summary>
  /// <param name="aType">The type whose serializable properties are to be retrieved.</param>
  /// <returns>An array of <see cref="PropertyInfo"/> objects representing the serializable properties of the specified type.</returns>
  public static PropertyInfo[] GetSerializableProperties(this Type aType)
  {
    if (_serializablePropertiesCache.TryGetValue(aType, out var cachedProperties))
    {
      return cachedProperties;
    }

    var allProperties = aType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

    var serializablePropertiesList = new List<PropertyInfo>();
    foreach (var property in allProperties)
    {
      if ((property.CanRead && (property.CanWrite || property.PropertyType.IsEnumerable()) && !property.IsIndexer()) &&
          property.GetCustomAttribute<XmlIgnoreAttribute>() == null)
      {
        serializablePropertiesList.Add(property);
      }
    }
    var result = serializablePropertiesList.ToArray();
    _serializablePropertiesCache[aType] = result;
    return result;
  }

  /// <summary>
  /// Splits the given array of serializable properties into two groups: those that are marked with the <see cref="XmlAttributeAttribute"/> and those that are not. Properties that are value types, strings, or have a static "Parse" method are also considered attribute properties.
  /// </summary>
  /// <param name="serializableProperties">An array of <see cref="PropertyInfo"/> objects representing the properties to be split.</param>
  /// <returns>A tuple containing two arrays of <see cref="PropertyInfo"/> objects: one for attribute properties and one for element properties.</returns>
  public static (PropertyInfo[] attributeProperties, PropertyInfo[] elementProperties) SplitAttributesAndElements
  (this PropertyInfo[] serializableProperties)
  {
    if (_splitPropertiesCache.TryGetValue(serializableProperties, out var cachedSplit))
    {
      return cachedSplit;
    }

    var attributePropertiesList = new List<PropertyInfo>();
    foreach (var property in serializableProperties)
    {
      if (property.GetCustomAttribute<XmlAttributeAttribute>() != null)
        attributePropertiesList.Add(property);
      else
        if (property.GetCustomAttribute<XmlElementAttribute>() != null)
          attributePropertiesList.Add(property);
        else
        {
          var propType = property.PropertyType.GetNotNullableType();
          if (propType.IsValueType || propType == typeof(string) ||
              propType.GetMethod("Parse", BindingFlags.Public | BindingFlags.Static) != null)
          {
            attributePropertiesList.Add(property);
          }
        }
    }
    var attributeProperties = attributePropertiesList.ToArray();
    var elementProperties = serializableProperties.Except(attributeProperties).ToArray();
    _splitPropertiesCache[serializableProperties] = (attributeProperties, elementProperties);
    return (attributeProperties, elementProperties);
  }
}
