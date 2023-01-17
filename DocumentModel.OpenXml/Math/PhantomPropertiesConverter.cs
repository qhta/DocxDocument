namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Phantom Properties.
/// </summary>
public static class PhantomPropertiesConverter
{
  /// <summary>
  /// Phantom Show.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetShowPhantom(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ShowPhantom>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetShowPhantom(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ShowPhantom>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ShowPhantom, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phantom Zero Width.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetZeroWidth(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ZeroWidth>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetZeroWidth(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ZeroWidth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ZeroWidth, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phantom Zero Ascent.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetZeroAscent(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ZeroAscent>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetZeroAscent(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ZeroAscent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ZeroAscent, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Phantom Zero Descent.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetZeroDescent(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ZeroDescent>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetZeroDescent(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ZeroDescent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ZeroDescent, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Transparent (Phantom).
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetTransparent(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Transparent>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetTransparent(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Transparent>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Transparent, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  private static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlProperties(DocumentFormat.OpenXml.Math.PhantomProperties openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.PhantomProperties? CreateModelElement(DocumentFormat.OpenXml.Math.PhantomProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.PhantomProperties();
      value.ShowPhantom = GetShowPhantom(openXmlElement);
      value.ZeroWidth = GetZeroWidth(openXmlElement);
      value.ZeroAscent = GetZeroAscent(openXmlElement);
      value.ZeroDescent = GetZeroDescent(openXmlElement);
      value.Transparent = GetTransparent(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.PhantomProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.PhantomProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetShowPhantom(openXmlElement, value?.ShowPhantom);
      SetZeroWidth(openXmlElement, value?.ZeroWidth);
      SetZeroAscent(openXmlElement, value?.ZeroAscent);
      SetZeroDescent(openXmlElement, value?.ZeroDescent);
      SetTransparent(openXmlElement, value?.Transparent);
      SetControlProperties(openXmlElement, value?.ControlProperties);
      return openXmlElement;
    }
    return default;
  }
}
