namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Box Properties.
/// </summary>
public static class BoxPropertiesConverter
{
  /// <summary>
  /// Operator Emulator.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetOperatorEmulator(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.OperatorEmulator>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetOperatorEmulator(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.OperatorEmulator>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.OperatorEmulator, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// No Break.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetNoBreak(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NoBreak>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetNoBreak(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NoBreak>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.NoBreak, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Differential.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetDifferential(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Differential>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDifferential(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Differential>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Differential, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Break.
  /// </summary>
  public static DocumentModel.Math.Break? GetBreak(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Break>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BreakConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBreak(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement, DocumentModel.Math.Break? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Break>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Math.BreakConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Break>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetAlignment(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Alignment>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetAlignment(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Alignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Alignment, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public static DocumentModel.Math.ControlProperties? GetControlProperties(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.ControlPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetControlProperties(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement, DocumentModel.Math.ControlProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Math.BoxProperties? CreateModelElement(DocumentFormat.OpenXml.Math.BoxProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.BoxProperties();
      value.OperatorEmulator = GetOperatorEmulator(openXmlElement);
      value.NoBreak = GetNoBreak(openXmlElement);
      value.Differential = GetDifferential(openXmlElement);
      value.Break = GetBreak(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.ControlProperties = GetControlProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.BoxProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.BoxProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
