using DocumentModel.XmlSerialization;

namespace DocumentModel.Drawings;
/// <summary>
/// Provides XML serialization support for the <see cref = "ColorHolder{T}"/> structure.
/// </summary>
public partial class ColorHolder<T> : IXmlSerializable
{
  /// <summary>
  /// This method is reserved and should not be used. Returns null as no schema is required.
  /// </summary>
  /// <returns>Always returns null.</returns>
  XmlSchema? IXmlSerializable.GetSchema() => null;
  /// <summary>
  /// Deserializes the instance from XML.
  /// </summary>
  /// <param name = "reader">The <see cref = "XmlReader"/> to read from.</param>
  /// <remarks>
  /// The InternalColor property is deserialized directly without any additional wrapping elements.
  /// </remarks>
  public void ReadXml(XmlReader reader)
  {
    var readerDepth = reader.Depth;

    if (reader.IsEmptyElement)
    {
      reader.ReadStartElement();
      InternalColor = null;
      return;
    }

    reader.ReadStartElement();
    while (reader.NodeType == XmlNodeType.Whitespace)
      reader.Read();

    if (reader.NodeType == XmlNodeType.EndElement)
    {
      reader.ReadEndElement();
      InternalColor = null;
      return;
    }

    var internalColorType = reader.LocalName switch
    {
      nameof(ColorType) => typeof(ColorType),
      nameof(RgbColorModelPercentage) => typeof(RgbColorModelPercentage),
      nameof(RgbColorModelHex) => typeof(RgbColorModelHex),
      nameof(HslColor) => typeof(HslColor),
      nameof(SystemColor) => typeof(SystemColor),
      nameof(PresetColor) => typeof(PresetColor),
      nameof(SchemeColor) => typeof(SchemeColor),
      _ => null
    };

    if (internalColorType != null)
    {
      var serializer = XmlSerializationHelper.CreateXmlSerializer(internalColorType);
      var internalColorObject = serializer.Deserialize(reader);
      this.Color = new ColorType{ InternalColor = internalColorObject as IColor };
    }
    else
    {
      Debug.WriteLine($"Unsupported color element in ReadXml: {reader.LocalName}");
      reader.Skip();
      InternalColor = null;
    }

    while (reader.NodeType == XmlNodeType.Whitespace)
      reader.Read();
    if (reader.NodeType == XmlNodeType.Element && reader.IsEmptyElement && reader.Depth == readerDepth+1)
      reader.Read();
    if (reader.NodeType == XmlNodeType.EndElement && reader.Depth == readerDepth)
      reader.ReadEndElement();
  }

  /// <summary>
  /// Serializes the instance to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>
  /// <remarks>
  /// The InternalColor property is serialized directly without any additional wrapping elements.
  /// </remarks>
  public void WriteXml(XmlWriter writer)
  {
    if (InternalColor == null)
    {
      Debug.WriteLine("InternalColor is null");
      return;
    }
    if (InternalColor is ColorType colorType)
    {
      colorType.WriteXml(writer);
    }
    else
    {
      var serializer = XmlSerializationHelper.CreateXmlSerializer(InternalColor.GetType(), out var namespaces);
      serializer.Serialize(writer, InternalColor, namespaces);
    }

  }
}
