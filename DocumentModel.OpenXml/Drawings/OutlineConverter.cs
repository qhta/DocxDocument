namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Outline Class.
/// </summary>
public static class OutlineConverter
{
  public static Boolean? GetNoFill(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetNoFill(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.NoFill();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSolidFill(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement, DocumentModel.Drawings.SolidFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SolidFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SolidFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetGradientFill(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement, DocumentModel.Drawings.GradientFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.GradientFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.GradientFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPatternFill(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement, DocumentModel.Drawings.PatternFill? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.PatternFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PatternFill>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.PresetLineDashKind? GetPresetDash(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DocumentModel.Drawings.PresetLineDashKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetPresetDash(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement, DocumentModel.Drawings.PresetLineDashKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetDash, DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DocumentModel.Drawings.PresetLineDashKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.CustomDash? GetCustomDash(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomDash>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CustomDashConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCustomDash(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement, DocumentModel.Drawings.CustomDash? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomDash>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.CustomDashConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.CustomDash>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetRound(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Round>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetRound(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Round>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.Round();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static Boolean? GetLineJoinBevel(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineJoinBevel>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetLineJoinBevel(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineJoinBevel>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Drawing.LineJoinBevel();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Miter? GetMiter(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Miter>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.MiterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMiter(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement, DocumentModel.Drawings.Miter? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Miter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.MiterConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Miter>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.LineEndPropertiesType? GetHeadEnd(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HeadEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineEndPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHeadEnd(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement, DocumentModel.Drawings.LineEndPropertiesType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HeadEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.LineEndPropertiesTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HeadEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.LineEndPropertiesType? GetTailEnd(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TailEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineEndPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTailEnd(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement, DocumentModel.Drawings.LineEndPropertiesType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.TailEnd>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.LineEndPropertiesTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.TailEnd>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.LinePropertiesExtensionList? GetLinePropertiesExtensionList(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LinePropertiesExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLinePropertiesExtensionList(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement, DocumentModel.Drawings.LinePropertiesExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.LinePropertiesExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Outline? CreateModelElement(DocumentFormat.OpenXml.Drawing.Outline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Outline();
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.PresetDash = GetPresetDash(openXmlElement);
      value.CustomDash = GetCustomDash(openXmlElement);
      value.Round = GetRound(openXmlElement);
      value.LineJoinBevel = GetLineJoinBevel(openXmlElement);
      value.Miter = GetMiter(openXmlElement);
      value.HeadEnd = GetHeadEnd(openXmlElement);
      value.TailEnd = GetTailEnd(openXmlElement);
      value.LinePropertiesExtensionList = GetLinePropertiesExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Outline? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Outline, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
