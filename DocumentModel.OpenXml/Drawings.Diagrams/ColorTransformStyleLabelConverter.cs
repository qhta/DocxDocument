namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Style Label.
/// </summary>
public static class ColorTransformStyleLabelConverter
{
  /// <summary>
  /// Name
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Fill Color List.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.FillColorList? GetFillColorList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.FillColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFillColorList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.FillColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.FillColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.FillColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Line Color List.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.LineColorList? GetLineColorList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.LineColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLineColorList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.LineColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.LineColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.LineColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Effect Color List.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.EffectColorList? GetEffectColorList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.EffectColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectColorList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.EffectColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.EffectColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.EffectColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Text Line Color List.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.TextLineColorList? GetTextLineColorList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.TextLineColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextLineColorList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.TextLineColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.TextLineColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextLineColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Text Fill Color List.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.TextFillColorList? GetTextFillColorList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.TextFillColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextFillColorList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.TextFillColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.TextFillColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextFillColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Text Effect Color List.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.TextEffectColorList? GetTextEffectColorList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.TextEffectColorListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextEffectColorList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.TextEffectColorList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.TextEffectColorListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.TextEffectColorList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Diagrams.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel();
      value.Name = GetName(openXmlElement);
      value.FillColorList = GetFillColorList(openXmlElement);
      value.LineColorList = GetLineColorList(openXmlElement);
      value.EffectColorList = GetEffectColorList(openXmlElement);
      value.TextLineColorList = GetTextLineColorList(openXmlElement);
      value.TextFillColorList = GetTextFillColorList(openXmlElement);
      value.TextEffectColorList = GetTextEffectColorList(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ColorTransformStyleLabel? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformStyleLabel, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
