using DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing;
using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the NonVisualInkContentPartProperties Class.
/// </summary>
public static class NonVisualInkContentPartPropertiesConverter
{
  /// <summary>
  ///   isComment, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetIsComment(NonVisualInkContentPartProperties? openXmlElement)
  {
    return openXmlElement?.IsComment?.Value;
  }

  public static void SetIsComment(NonVisualInkContentPartProperties? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IsComment = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.IsComment = null;
  }

  /// <summary>
  ///   ContentPartLocks.
  /// </summary>
  public static ContentPartLocks? GetContentPartLocks(NonVisualInkContentPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>();
    if (itemElement != null)
      return ContentPartLocksConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetContentPartLocks(NonVisualInkContentPartProperties? openXmlElement, ContentPartLocks? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ContentPartLocksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ContentPartLocks>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public static OfficeArtExtensionList2? GetOfficeArtExtensionList(NonVisualInkContentPartProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
    if (itemElement != null)
      return OfficeArtExtensionList2Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetOfficeArtExtensionList(NonVisualInkContentPartProperties? openXmlElement, OfficeArtExtensionList2? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionList2Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.NonVisualInkContentPartProperties? CreateModelElement(NonVisualInkContentPartProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.NonVisualInkContentPartProperties();
      value.IsComment = GetIsComment(openXmlElement);
      value.ContentPartLocks = GetContentPartLocks(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.NonVisualInkContentPartProperties? value)
    where OpenXmlElementType : NonVisualInkContentPartProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIsComment(openXmlElement, value?.IsComment);
      SetContentPartLocks(openXmlElement, value?.ContentPartLocks);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}