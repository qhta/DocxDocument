using DocumentFormat.OpenXml.Office2019.Drawing;
using DocumentModel.Drawings;
using DocumentModel.Drawings.Office.ScriptLink;
using DocumentModel.OpenXml.Drawings.Office.ScriptLink;
using NonVisualDrawingPropertiesExtension = DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
public static class NonVisualDrawingPropertiesExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(NonVisualDrawingPropertiesExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static CompatExtension? GetCompatExtension(NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension>();
    if (itemElement != null)
      return CompatExtensionConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCompatExtension(NonVisualDrawingPropertiesExtension? openXmlElement, CompatExtension? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CompatExtensionConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.CompatExtension>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackgroundProperties? GetBackgroundProperties(NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties>();
    if (itemElement != null)
      return BackgroundPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackgroundProperties(NonVisualDrawingPropertiesExtension? openXmlElement, BackgroundProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackgroundPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.BackgroundProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CreationId? GetCreationId(NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.CreationId>();
    if (itemElement != null)
      return CreationIdConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCreationId(NonVisualDrawingPropertiesExtension? openXmlElement, CreationId? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.CreationId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreationIdConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.CreationId>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PredecessorDrawingElementReference? GetPredecessorDrawingElementReference(NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference>();
    if (itemElement != null)
      return PredecessorDrawingElementReferenceConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPredecessorDrawingElementReference(NonVisualDrawingPropertiesExtension? openXmlElement, PredecessorDrawingElementReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PredecessorDrawingElementReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.PredecessorDrawingElementReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetDecorative(NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Decorative>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDecorative(NonVisualDrawingPropertiesExtension? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Decorative>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Decorative();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ClassificationOutcome? GetClassificationOutcome(NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome>();
    if (itemElement != null)
      return ClassificationOutcomeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetClassificationOutcome(NonVisualDrawingPropertiesExtension? openXmlElement, ClassificationOutcome? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ClassificationOutcomeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2021.Drawing.DocumentClassification.ClassificationOutcome>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ScriptLink? GetScriptLink(NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink>();
    if (itemElement != null)
      return ScriptLinkConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScriptLink(NonVisualDrawingPropertiesExtension? openXmlElement, ScriptLink? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ScriptLinkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.NonVisualDrawingPropertiesExtension? CreateModelElement(NonVisualDrawingPropertiesExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.NonVisualDrawingPropertiesExtension();
      value.Uri = GetUri(openXmlElement);
      value.CompatExtension = GetCompatExtension(openXmlElement);
      value.BackgroundProperties = GetBackgroundProperties(openXmlElement);
      value.CreationId = GetCreationId(openXmlElement);
      value.PredecessorDrawingElementReference = GetPredecessorDrawingElementReference(openXmlElement);
      value.Decorative = GetDecorative(openXmlElement);
      value.ClassificationOutcome = GetClassificationOutcome(openXmlElement);
      value.ScriptLink = GetScriptLink(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.NonVisualDrawingPropertiesExtension? value)
    where OpenXmlElementType : NonVisualDrawingPropertiesExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetCompatExtension(openXmlElement, value?.CompatExtension);
      SetBackgroundProperties(openXmlElement, value?.BackgroundProperties);
      SetCreationId(openXmlElement, value?.CreationId);
      SetPredecessorDrawingElementReference(openXmlElement, value?.PredecessorDrawingElementReference);
      SetDecorative(openXmlElement, value?.Decorative);
      SetClassificationOutcome(openXmlElement, value?.ClassificationOutcome);
      SetScriptLink(openXmlElement, value?.ScriptLink);
      return openXmlElement;
    }
    return default;
  }
}