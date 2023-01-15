using DocumentFormat.OpenXml.Drawing.Diagrams;
using Scene3D = DocumentModel.Drawings.Diagrams.Scene3D;
using Shape3D = DocumentModel.Drawings.Diagrams.Shape3D;
using Style = DocumentModel.Drawings.Diagrams.Style;
using TextProperties = DocumentModel.Drawings.Diagrams.TextProperties;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Style Label.
/// </summary>
public static class StyleLabelConverter
{
  /// <summary>
  ///   Style Name
  /// </summary>
  public static String? GetName(StyleLabel? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(StyleLabel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   3-D Scene.
  /// </summary>
  public static Scene3D? GetScene3D(StyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
    if (itemElement != null)
      return Scene3DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScene3D(StyleLabel? openXmlElement, Scene3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Scene3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   3-D Shape Properties.
  /// </summary>
  public static Shape3D? GetShape3D(StyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D>();
    if (itemElement != null)
      return Shape3DConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShape3D(StyleLabel? openXmlElement, Shape3D? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Shape3DConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Shape3D>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Text Properties.
  /// </summary>
  public static TextProperties? GetTextProperties(StyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties>();
    if (itemElement != null)
      return TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextProperties(StyleLabel? openXmlElement, TextProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Shape Style.
  /// </summary>
  public static Style? GetStyle(StyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Style>();
    if (itemElement != null)
      return StyleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetStyle(StyleLabel? openXmlElement, Style? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Style>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StyleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Style>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(StyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(StyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.StyleLabel? CreateModelElement(StyleLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.StyleLabel();
      value.Name = GetName(openXmlElement);
      value.Scene3D = GetScene3D(openXmlElement);
      value.Shape3D = GetShape3D(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.StyleLabel? value)
    where OpenXmlElementType : StyleLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetScene3D(openXmlElement, value?.Scene3D);
      SetShape3D(openXmlElement, value?.Shape3D);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetStyle(openXmlElement, value?.Style);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}