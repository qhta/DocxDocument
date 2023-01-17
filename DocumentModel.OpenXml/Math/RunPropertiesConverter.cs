namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Run Properties.
/// </summary>
public static class RunPropertiesConverter
{
  /// <summary>
  /// Literal.
  /// </summary>
  private static DocumentModel.Math.BooleanKind? GetLiteral(DocumentFormat.OpenXml.Math.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Literal>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetLiteral(DocumentFormat.OpenXml.Math.RunProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Literal>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Literal, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.BooleanKind? GetNormalText(DocumentFormat.OpenXml.Math.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NormalText>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNormalText(DocumentFormat.OpenXml.Math.RunProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.NormalText>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.NormalText, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.ScriptKind? GetScript(DocumentFormat.OpenXml.Math.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Script>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.ScriptValues, DocumentModel.Math.ScriptKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetScript(DocumentFormat.OpenXml.Math.RunProperties openXmlElement, DocumentModel.Math.ScriptKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Script>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Script, DocumentFormat.OpenXml.Math.ScriptValues, DocumentModel.Math.ScriptKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.StyleKind? GetStyle(DocumentFormat.OpenXml.Math.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Style>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.StyleValues, DocumentModel.Math.StyleKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetStyle(DocumentFormat.OpenXml.Math.RunProperties openXmlElement, DocumentModel.Math.StyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Style>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Style, DocumentFormat.OpenXml.Math.StyleValues, DocumentModel.Math.StyleKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Math.Break? GetBreak(DocumentFormat.OpenXml.Math.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Math.Break>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Math.BreakConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBreak(DocumentFormat.OpenXml.Math.RunProperties openXmlElement, DocumentModel.Math.Break? value)
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
  
  private static DocumentModel.Math.BooleanKind? GetAlignment(DocumentFormat.OpenXml.Math.RunProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Alignment>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetAlignment(DocumentFormat.OpenXml.Math.RunProperties openXmlElement, DocumentModel.Math.BooleanKind? value)
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
  
  public static DocumentModel.Math.RunProperties? CreateModelElement(DocumentFormat.OpenXml.Math.RunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.RunProperties();
      value.Literal = GetLiteral(openXmlElement);
      value.NormalText = GetNormalText(openXmlElement);
      value.Script = GetScript(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.Break = GetBreak(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.RunProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.RunProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLiteral(openXmlElement, value?.Literal);
      SetNormalText(openXmlElement, value?.NormalText);
      SetScript(openXmlElement, value?.Script);
      SetStyle(openXmlElement, value?.Style);
      SetBreak(openXmlElement, value?.Break);
      SetAlignment(openXmlElement, value?.Alignment);
      return openXmlElement;
    }
    return default;
  }
}
