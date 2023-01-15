using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Text Properties.
/// </summary>
public static class TextPropertiesConverter
{
  /// <summary>
  ///   Apply 3D shape properties.
  /// </summary>
  public static Shape3DType? GetShape3DType(TextProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
    if (itemElement != null)
      return Shape3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShape3DType(TextProperties? openXmlElement, Shape3DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Shape3DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Shape3DType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   No text in 3D scene.
  /// </summary>
  public static FlatText? GetFlatText(TextProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
    if (itemElement != null)
      return FlatTextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFlatText(TextProperties? openXmlElement, FlatText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.FlatText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FlatTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.FlatText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.TextProperties? CreateModelElement(TextProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.TextProperties();
      value.Shape3DType = GetShape3DType(openXmlElement);
      value.FlatText = GetFlatText(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.TextProperties? value)
    where OpenXmlElementType : TextProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShape3DType(openXmlElement, value?.Shape3DType);
      SetFlatText(openXmlElement, value?.FlatText);
      return openXmlElement;
    }
    return default;
  }
}