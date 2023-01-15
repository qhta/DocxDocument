using DocumentFormat.OpenXml.Drawing;
using ConnectionShapeLocks = DocumentModel.Drawings.ConnectionShapeLocks;
using ConnectionType = DocumentModel.Drawings.ConnectionType;
using NonVisualConnectionShapeProperties = DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties;

namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
///   Non-Visual Connection Shape Drawing Properties.
/// </summary>
public static class NonVisualConnectionShapePropertiesConverter
{
  /// <summary>
  ///   Connection Shape Locks.
  /// </summary>
  public static ConnectionShapeLocks? GetConnectionShapeLocks(NonVisualConnectionShapeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
    if (itemElement != null)
      return ConnectionShapeLocksConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConnectionShapeLocks(NonVisualConnectionShapeProperties? openXmlElement, ConnectionShapeLocks? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConnectionShapeLocksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ConnectionShapeLocks>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Connection Start.
  /// </summary>
  public static ConnectionType? GetStartConnection(NonVisualConnectionShapeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<StartConnection>();
    if (itemElement != null)
      return ConnectionTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStartConnection(NonVisualConnectionShapeProperties? openXmlElement, ConnectionType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<StartConnection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConnectionTypeConverter.CreateOpenXmlElement<StartConnection>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Connection End.
  /// </summary>
  public static ConnectionType? GetEndConnection(NonVisualConnectionShapeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<EndConnection>();
    if (itemElement != null)
      return ConnectionTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEndConnection(NonVisualConnectionShapeProperties? openXmlElement, ConnectionType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<EndConnection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConnectionTypeConverter.CreateOpenXmlElement<EndConnection>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(NonVisualConnectionShapeProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(NonVisualConnectionShapeProperties? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawing.NonVisualConnectionShapeProperties? CreateModelElement(NonVisualConnectionShapeProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.NonVisualConnectionShapeProperties();
      value.ConnectionShapeLocks = GetConnectionShapeLocks(openXmlElement);
      value.StartConnection = GetStartConnection(openXmlElement);
      value.EndConnection = GetEndConnection(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.NonVisualConnectionShapeProperties? value)
    where OpenXmlElementType : NonVisualConnectionShapeProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetConnectionShapeLocks(openXmlElement, value?.ConnectionShapeLocks);
      SetStartConnection(openXmlElement, value?.StartConnection);
      SetEndConnection(openXmlElement, value?.EndConnection);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}