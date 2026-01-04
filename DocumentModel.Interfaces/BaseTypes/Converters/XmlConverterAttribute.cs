namespace DocumentModel;

/// <summary>
///   Specifies the XML converter to use for serializing and deserializing a type.
/// </summary>
/// <remarks>
///   This attribute is used to indicate which converter should handle XML serialization
///   for custom types like HexBinary. The actual converter implementation should be
///   registered with your XML serialization framework.
/// </remarks>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct, AllowMultiple = false)]
public class XmlConverterAttribute : Attribute
{
  /// <summary>
  ///   Initializes a new instance of the XmlConverterAttribute class.
  /// </summary>
  /// <param name="converterType">The type of the converter to use for XML serialization.</param>
  public XmlConverterAttribute(Type converterType)
  {
    ConverterType = converterType;
  }

  /// <summary>
  ///   Gets the type of the converter to use for XML serialization.
  /// </summary>
  public Type ConverterType { get; }
}