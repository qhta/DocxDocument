using DocumentFormat.OpenXml.Drawing;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ConnectionType Class.
/// </summary>
public static class ConnectionTypeConverter
{
  /// <summary>
  ///   Identifier
  /// </summary>
  public static UInt32? GetId(ConnectionType? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(ConnectionType? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }

  /// <summary>
  ///   Index
  /// </summary>
  public static UInt32? GetIndex(ConnectionType? openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }

  public static void SetIndex(ConnectionType? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = value;
  }

  public static DocumentModel.Drawings.ConnectionType? CreateModelElement(ConnectionType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ConnectionType();
      value.Id = GetId(openXmlElement);
      value.Index = GetIndex(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ConnectionType? value)
    where OpenXmlElementType : ConnectionType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetIndex(openXmlElement, value?.Index);
      return openXmlElement;
    }
    return default;
  }
}