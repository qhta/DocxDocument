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
    var (_, elementProperties) = SplitProperties(serializableProperties);

    // Read attributes
    if (reader.NodeType == XmlNodeType.Element && reader.MoveToFirstAttribute())
    {
      do
      {
        var propName = reader.LocalName;
        var propValue = reader.Value;
        var property = serializableProperties.FirstOrDefault(p => p.Name.Equals(propName, StringComparison.OrdinalIgnoreCase));
        if (property != null && property.CanWrite)
        {
          var valueType = property.PropertyType.GetNotNullableType();
          var value = ObjectToStringConverter.ConvertFromString(propValue, valueType);
          property.SetValue(this, value);
        }
      }
      while (reader.MoveToNextAttribute());

      reader.MoveToElement();
    }

    var isEmptyElement = reader.IsEmptyElement;
    reader.ReadStartElement();
    if (isEmptyElement)
      return;

    reader.MoveToContent();

    // Read child elements serialized as properties.
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

      reader.MoveToContent();
    }

    // Read remaining child elements serialized as collection items.
    var thisType = this.GetType();
    var addMethods = thisType.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                             .Where(m => m.Name.StartsWith("Add") && m.GetParameters().Length == 1)
                             .ToArray();

    while (reader.NodeType == XmlNodeType.Element)
    {
      var elementName = reader.LocalName;
      var elementType = XmlSerializationHelper.ResolveType(elementName, this.GetType().Namespace!);
      var item = Activator.CreateInstance(elementType);
      if (item is IXmlSerializable xmlSerializable)
      {
        xmlSerializable.ReadXml(reader);
        var addMethod = addMethods.FirstOrDefault(m => m.GetParameters()[0].ParameterType.IsAssignableFrom(elementType));
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
        reader.Skip();
      }

      reader.MoveToContent();
    }

    if (reader.NodeType == XmlNodeType.EndElement)
      reader.ReadEndElement();
  }

  /// <summary>
  /// Writes the XML representation of the current instance to the specified <see cref="XmlWriter"/>.
  /// </summary>
  /// <param name="writer">The <see cref="XmlWriter"/> to which the XML representation of the current instance will be written.</param>
  public virtual void WriteXml(XmlWriter writer)
  {
    var serializableProperties = GetSerializableProperties();
    var (attributeProperties, elementProperties) = SplitProperties(serializableProperties);
    foreach (var property in attributeProperties)
    {
      if (property.PropertyType.GetNotNullableType()==typeof(DMW.PixelsMeasure))
        Debug.Assert(true);
      var value = property.GetValue(this);
      if (value != null)
      {
        var valueType = value.GetType();
        TypeToStringConverter.RegisterType(valueType);
        string? valueString = ObjectToStringConverter.ConvertToString(value);
        writer.WriteAttributeString(property.Name.ToLowerFirst(), valueString);
      }
    }
    if (elementProperties.Any())
    {
      foreach (var property in elementProperties)
      {
        var value = property.GetValue(this);
        if (value != null)
        {
          //var valueType = value.GetType();
          //TypeToStringConverter.RegisterType(valueType);
          writer.WriteStartElement(property.Name.ToLowerFirst());
          if (value is IXmlSerializable xmlSerializable)
          {
            xmlSerializable.WriteXml(writer);
          }
          writer.WriteEndElement();
        }
      }
    }
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
  protected virtual PropertyInfo[] GetSerializableProperties()
  {
    var aType = this.GetType();
    var allProperties = aType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

    var serializablePropertiesList = new List<PropertyInfo>();
    foreach (var property in allProperties)
    {
      if (property.CanRead && property.GetCustomAttribute<XmlIgnoreAttribute>() == null
        && (property.CanWrite || property.PropertyType.IsEnumerable())
        && !property.IsIndexer())
      {
        serializablePropertiesList.Add(property);
      }
    }
    return serializablePropertiesList.ToArray();
  }

  /// <summary>
  /// Splits the serializable properties of the current instance into two groups: those that are marked with the <see cref="XmlAttributeAttribute"/> and those that are not.
  /// </summary>
  /// <param name="serializableProperties">An array of <see cref="PropertyInfo"/> objects representing the properties to be split.</param>
  /// <returns>A tuple containing two arrays of <see cref="PropertyInfo"/> objects: one for attribute properties and one for element properties.</returns>
  protected virtual (PropertyInfo[] attributeProperties, PropertyInfo[] elementProperties) SplitProperties
    (PropertyInfo[] serializableProperties)
  {
    var attributePropertiesList = new List<PropertyInfo>();
    foreach (var property in serializableProperties) {
      if (property.GetCustomAttribute<XmlAttributeAttribute>() != null)
        attributePropertiesList.Add(property);
      else
      {
        var propType = property.PropertyType.GetNotNullableType();
        if (propType.IsValueType || propType==typeof(string) ||
            propType.GetMethod("TryParse", BindingFlags.Public | BindingFlags.Static) != null)
        {
          attributePropertiesList.Add(property);
        }
      }
    }
    var attributeProperties = attributePropertiesList.ToArray();
    var elementProperties = serializableProperties.Except(attributeProperties).ToArray();
    return (attributeProperties, elementProperties);
  }
}
