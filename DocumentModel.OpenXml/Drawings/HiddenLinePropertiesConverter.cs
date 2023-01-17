namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenLineProperties Class.
/// </summary>
public static class HiddenLinePropertiesConverter
{
  /// <summary>
  /// line width
  /// </summary>
  private static Int32? GetWidth(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    return openXmlElement.Width?.Value;
  }
  
  private static void SetWidth(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, Int32? value)
  {
    openXmlElement.Width = value;
  }
  
  /// <summary>
  /// line cap
  /// </summary>
  private static DocumentModel.Drawings.LineCapKind? GetCapType(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DocumentModel.Drawings.LineCapKind>(openXmlElement?.CapType?.Value);
  }
  
  private static void SetCapType(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, DocumentModel.Drawings.LineCapKind? value)
  {
    openXmlElement.CapType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.LineCapValues, DocumentModel.Drawings.LineCapKind>(value);
  }
  
  /// <summary>
  /// compound line type
  /// </summary>
  private static DocumentModel.Drawings.CompoundLineKind? GetCompoundLineType(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DocumentModel.Drawings.CompoundLineKind>(openXmlElement?.CompoundLineType?.Value);
  }
  
  private static void SetCompoundLineType(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, DocumentModel.Drawings.CompoundLineKind? value)
  {
    openXmlElement.CompoundLineType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.CompoundLineValues, DocumentModel.Drawings.CompoundLineKind>(value);
  }
  
  /// <summary>
  /// pen alignment
  /// </summary>
  private static DocumentModel.Drawings.PenAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DocumentModel.Drawings.PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static void SetAlignment(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, DocumentModel.Drawings.PenAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PenAlignmentValues, DocumentModel.Drawings.PenAlignmentKind>(value);
  }
  
  private static Boolean? GetNoFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
    return itemElement != null;
  }
  
  private static void SetNoFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, Boolean? value)
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
  
  private static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSolidFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, DocumentModel.Drawings.SolidFill? value)
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
  
  private static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGradientFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, DocumentModel.Drawings.GradientFill? value)
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
  
  private static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPatternFill(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, DocumentModel.Drawings.PatternFill? value)
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
  
  private static DocumentModel.Drawings.PresetLineDashKind? GetPresetDash(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DocumentModel.Drawings.PresetLineDashKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPresetDash(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, DocumentModel.Drawings.PresetLineDashKind? value)
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
  
  private static DocumentModel.Drawings.CustomDash? GetCustomDash(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.CustomDash>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.CustomDashConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCustomDash(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, DocumentModel.Drawings.CustomDash? value)
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
  
  private static Boolean? GetRound(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Round>();
    return itemElement != null;
  }
  
  private static void SetRound(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, Boolean? value)
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
  
  private static Boolean? GetLineJoinBevel(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.LineJoinBevel>();
    return itemElement != null;
  }
  
  private static void SetLineJoinBevel(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, Boolean? value)
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
  
  private static DocumentModel.Drawings.Miter? GetMiter(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Miter>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.MiterConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMiter(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, DocumentModel.Drawings.Miter? value)
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
  
  private static DocumentModel.Drawings.LineEndPropertiesType? GetHeadEnd(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HeadEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineEndPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHeadEnd(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, DocumentModel.Drawings.LineEndPropertiesType? value)
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
  
  private static DocumentModel.Drawings.LineEndPropertiesType? GetTailEnd(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.TailEnd>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LineEndPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTailEnd(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, DocumentModel.Drawings.LineEndPropertiesType? value)
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
  
  private static DocumentModel.Drawings.LinePropertiesExtensionList? GetLinePropertiesExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.LinePropertiesExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.LinePropertiesExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLinePropertiesExtensionList(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties openXmlElement, DocumentModel.Drawings.LinePropertiesExtensionList? value)
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
  
  public static DocumentModel.Drawings.HiddenLineProperties? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HiddenLineProperties();
      value.Width = GetWidth(openXmlElement);
      value.CapType = GetCapType(openXmlElement);
      value.CompoundLineType = GetCompoundLineType(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.HiddenLineProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWidth(openXmlElement, value?.Width);
      SetCapType(openXmlElement, value?.CapType);
      SetCompoundLineType(openXmlElement, value?.CompoundLineType);
      SetAlignment(openXmlElement, value?.Alignment);
      SetNoFill(openXmlElement, value?.NoFill);
      SetSolidFill(openXmlElement, value?.SolidFill);
      SetGradientFill(openXmlElement, value?.GradientFill);
      SetPatternFill(openXmlElement, value?.PatternFill);
      SetPresetDash(openXmlElement, value?.PresetDash);
      SetCustomDash(openXmlElement, value?.CustomDash);
      SetRound(openXmlElement, value?.Round);
      SetLineJoinBevel(openXmlElement, value?.LineJoinBevel);
      SetMiter(openXmlElement, value?.Miter);
      SetHeadEnd(openXmlElement, value?.HeadEnd);
      SetTailEnd(openXmlElement, value?.TailEnd);
      SetLinePropertiesExtensionList(openXmlElement, value?.LinePropertiesExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
