using DocumentModel.Drawings;
using ObjectDefaults = DocumentFormat.OpenXml.Drawing.ObjectDefaults;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the ObjectDefaults Class.
/// </summary>
public static class ObjectDefaultsConverter
{
  /// <summary>
  ///   Shape Default.
  /// </summary>
  public static ShapeDefault? GetShapeDefault(ObjectDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeDefault>();
    if (itemElement != null)
      return ShapeDefaultConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeDefault(ObjectDefaults? openXmlElement, ShapeDefault? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ShapeDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ShapeDefault>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Line Default.
  /// </summary>
  public static LineDefault? GetLineDefault(ObjectDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineDefault>();
    if (itemElement != null)
      return LineDefaultConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLineDefault(ObjectDefaults? openXmlElement, LineDefault? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LineDefault>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Text Default.
  /// </summary>
  public static TextDefault? GetTextDefault(ObjectDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextDefault>();
    if (itemElement != null)
      return TextDefaultConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextDefault(ObjectDefaults? openXmlElement, TextDefault? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TextDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TextDefault>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ExtensionList? GetExtensionList(ObjectDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(ObjectDefaults? openXmlElement, DocumentModel.Drawings.ExtensionList? value)
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

  public static DocumentModel.Drawings.ObjectDefaults? CreateModelElement(ObjectDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ObjectDefaults();
      value.ShapeDefault = GetShapeDefault(openXmlElement);
      value.LineDefault = GetLineDefault(openXmlElement);
      value.TextDefault = GetTextDefault(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ObjectDefaults? value)
    where OpenXmlElementType : ObjectDefaults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShapeDefault(openXmlElement, value?.ShapeDefault);
      SetLineDefault(openXmlElement, value?.LineDefault);
      SetTextDefault(openXmlElement, value?.TextDefault);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}