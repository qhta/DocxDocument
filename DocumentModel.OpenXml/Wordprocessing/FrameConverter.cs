namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Frame Properties.
/// </summary>
public static class FrameConverter
{
  /// <summary>
  /// Frame Size.
  /// </summary>
  public static String? GetFrameSize(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement)
  {
    return openXmlElement?.FrameSize?.Val?.Value;
  }
  
  public static void SetFrameSize(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Frame Name.
  /// </summary>
  public static String? GetFrameName(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.FrameName");
  }
  
  public static void SetFrameName(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Source File for Frame.
  /// </summary>
  public static DocumentModel.Wordprocessing.RelationshipType? GetSourceFileReference(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSourceFileReference(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement, DocumentModel.Wordprocessing.RelationshipType? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Left and Right Margin for Frame.
  /// </summary>
  public static UInt32? GetMarginWidth(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMarginWidth(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Top and Bottom Margin for Frame.
  /// </summary>
  public static UInt32? GetMarginHeight(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMarginHeight(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Scrollbar Display Option.
  /// </summary>
  public static DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind? GetScrollbarVisibility(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ScrollbarVisibility>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues, DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetScrollbarVisibility(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement, DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ScrollbarVisibility>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ScrollbarVisibility, DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues, DocumentModel.Wordprocessing.FrameScrollbarVisibilityKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Frame Cannot Be Resized.
  /// </summary>
  public static DocumentModel.Wordprocessing.OnOffOnlyKind? GetNoResizeAllowed(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoResizeAllowed>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetNoResizeAllowed(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NoResizeAllowed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NoResizeAllowed, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Maintain Link to Existing File.
  /// </summary>
  public static DocumentModel.Wordprocessing.OnOffOnlyKind? GetLinkedToFile(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkedToFile>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLinkedToFile(DocumentFormat.OpenXml.Wordprocessing.Frame? openXmlElement, DocumentModel.Wordprocessing.OnOffOnlyKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.LinkedToFile>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.LinkedToFile, DocumentFormat.OpenXml.Wordprocessing.OnOffOnlyValues, DocumentModel.Wordprocessing.OnOffOnlyKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
