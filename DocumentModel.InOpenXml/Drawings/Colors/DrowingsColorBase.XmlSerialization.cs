namespace DocumentModel.Drawings;
/// <summary>
/// Provides XML serialization support for the <see cref = "DrawingsColorBase"/> structure.
/// </summary>
public partial class DrawingsColorBase<T> : IXmlSerializable
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
  public override void ReadXml(XmlReader reader)
  {
    var readerDepth = reader.Depth;
    if (reader.IsEmptyElement)
    {
      reader.ReadStartElement();
      return;
    }

    reader.ReadStartElement();
    reader.MoveToContent();
    //base.ReadXml(reader);
    //if (reader.NodeType == XmlNodeType.EndElement)
    //  reader.ReadEndElement();
    var transformationType = reader.LocalName switch
    {
      nameof(Tint) => typeof(Tint),
      nameof(Shade) => typeof(Shade),
      _ => null
    };

    if (transformationType != null)
    {
      var serializer = XmlSerializationHelper.CreateXmlSerializer(transformationType);
      var transformationObject = serializer.Deserialize(reader);
      ColorTransformations.Add((ColorTransformation)transformationObject!);
    }
    else
    {
      Debug.WriteLine($"Unsupported color element in ReadXml: {reader.LocalName}");
      reader.Skip();
    }

    while (reader.NodeType == XmlNodeType.Whitespace)
      reader.Read();
    if (reader.NodeType == XmlNodeType.Element && reader.IsEmptyElement)
      reader.Read();
    if (reader.NodeType == XmlNodeType.EndElement && reader.Depth == readerDepth)
      reader.ReadEndElement();

  }

  /// <summary>
  /// Serializes the instance to XML.
  /// </summary>
  /// <param name = "writer">The <see cref = "XmlWriter"/> to write to.</param>
  public override void WriteXml(XmlWriter writer)
  {
    foreach (var transformation in ColorTransformations)
    {
      var serializer = XmlSerializationHelper.CreateXmlSerializer(transformation.GetType(), out var namespaces);
      serializer.Serialize(writer, transformation, namespaces);
    }
  }
}
