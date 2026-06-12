using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.XmlSerialization;

public static class XmlSerializationHelper
{

  /// <summary>
  /// Serializes an object to XML using its runtime type.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <param name="modelTypes">Array of model types to include in the serializer.</param>
  /// <returns>Serialized XML text.</returns>
  public static string SerializeObjectToXml(object data, Type[] modelTypes)
  {
    var xmlSerializer = CreateXmlSerializer(data, modelTypes, out var namespaces);
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, data, namespaces);
      return stringWriter.ToString();
    }
  }

  /// <summary>
  /// Deserializes XML to an object of the specified type.
  /// </summary>
  /// <param name="dataType">Target type.</param>
  /// <param name="xml">XML input.</param>
  /// <returns>Deserialized instance or null.</returns>
  public static object? DeserializeObjectFromXml(Type dataType, string xml)
  {
    var xmlSerializer = new XmlSerializer(dataType);
    using (var stringReader = new StringReader(xml))
    {
      return xmlSerializer.Deserialize(stringReader);
    }
  }

  /// <summary>
  /// Creates an XmlSerializer for the given data object, handling type overrides for generic ModelElement types.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <param name="modelTypes">Array of model types to include in the serializer.</param>
  /// <param name="namespaces">Output parameter for XML namespaces.</param>
  /// <returns>XmlSerializer instance.</returns>
  public static XmlSerializer CreateXmlSerializer(object data, Type[] modelTypes, out XmlSerializerNamespaces namespaces)
  => CreateXmlSerializer(data.GetType(), modelTypes, out namespaces);

  /// <summary>
  /// Creates an XmlSerializer for the specified root type, including overrides for generic ModelElement types to ensure unique XML type names.
  /// </summary>
  /// <param name="rootType">The root type for the XmlSerializer.</param>
  /// <param name="modelTypes">Array of model types to include in the serializer.</param>
  /// <param name="namespaces">Output parameter for XML namespaces.</param>
  /// <returns>XmlSerializer instance.</returns>
  public static XmlSerializer CreateXmlSerializer(Type rootType, Type[] modelTypes, out XmlSerializerNamespaces namespaces)
  {
    var UniqueTypeNames = new HashSet<string>();
    var overrides = new XmlAttributeOverrides();
    //var modelTypes = typeof(DMW.Document).Assembly.GetTypes()
    //  .Where(t => t.IsClass && !t.IsAbstract && !t.IsGenericType && !t.IsConstructedGenericType
    //            && !t.Implements(typeof(System.Collections.IDictionary))
    //  && t.GetConstructor([]) != null).ToArray();

    List<Type> visitedTypes = new List<Type>();
    foreach (var t in modelTypes)
    {
      //Debug.WriteLine($"GetXmlAttributeOverrides for {t.FullName}");
      GetXmlAttributeOverrides(t);
    }

    namespaces = new XmlSerializerNamespaces();
    namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
    namespaces.Add("d", "DocumentModel.Drawings");
    namespaces.Add("wd", "DocumentModel.Wordprocessing.Drawings");
    namespaces.Add("dw", "DocumentModel.Drawings.Wordprocessing");
    namespaces.Add("m", "DocumentModel.Math");

    var xmlSerializer = new XmlSerializer(rootType, overrides, modelTypes, null, null);
    return xmlSerializer;

    void GetXmlAttributeOverrides(Type? b)
    {
      if (b != null && b != typeof(object))
      {
        if (visitedTypes.Contains(b))
          return;
        visitedTypes.Add(b);
        if ((b.FullName ?? "").Contains("<>"))
          return;
        if (b.IsGenericType /*&& b.GetGenericTypeDefinition() == typeof(DM.ModelElement<>)*/)
        {
          var arg = b.GetGenericArguments()[0];
          if (arg.Name.Contains("<>"))
            return;
          if (!string.IsNullOrEmpty(arg.Namespace))
          {
            var unique = $"ModelElementOf_{arg.Namespace!.Replace('.', '_')}_{arg.Name}";
            if (UniqueTypeNames.Add(unique))
              overrides.Add(b, new XmlAttributes { XmlType = new XmlTypeAttribute(unique) });
          }
        }
        //Debug.WriteLine($"GetXmlAttributeOverrides2 for {b.BaseType?.FullName}");
        GetXmlAttributeOverrides(b.BaseType);
      }
    }
  }
  /// <summary>
  /// Gets XML namespace for a model type based on its CLR namespace.
  /// </summary>
  /// <param name="type">Type for which XML namespace is generated.</param>
  /// <returns>XML namespace string.</returns>
  public static string GetXmlNamespaceForType(Type type)
  {
    var typeNamespace = type.Namespace ?? "DocumentModel";
    if (typeNamespace.StartsWith("DocumentModel.", StringComparison.Ordinal))
      return "urn:docmodel:" + typeNamespace.Substring("DocumentModel.".Length).ToLowerInvariant().Replace('.', ':');
    return "urn:docmodel:global";
  }

  /// <summary>
  /// Adds an XML type override for a closed generic AbstractColor{T}"/> type.
  /// </summary>
  /// <param name="overrides">Override collection to populate.</param>
  /// <param name="type">Closed generic abstract color type to override.</param>
  /// <param name="xmlTypeName">Unique XML type name.</param>
  /// <param name="xmlNamespace">XML namespace for the type.</param>
  public static void AddAbstractColorOverride(XmlAttributeOverrides overrides, Type type, string xmlTypeName, string xmlNamespace)
  {
    var attrs = new XmlAttributes
    {
      XmlType = new XmlTypeAttribute
      {
        TypeName = xmlTypeName,
        Namespace = xmlNamespace
      }
    };
    overrides.Add(type, attrs);
  }

}
