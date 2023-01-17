namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TextOutlineEffect Class.
/// </summary>
public static class TextOutlineEffectConverter
{
  /// <summary>
  /// w, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetLineWidth(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement)
  {
    return openXmlElement.LineWidth?.Value;
  }
  
  private static void SetLineWidth(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement, Int32? value)
  {
    openXmlElement.LineWidth = value;
  }
  
  /// <summary>
  /// cap, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.Wordprocessing.LineCapKind? GetCapType(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues, DocumentModel.Wordprocessing.LineCapKind>(openXmlElement?.CapType?.Value);
  }
  
  private static void SetCapType(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement, DocumentModel.Wordprocessing.LineCapKind? value)
  {
    openXmlElement.CapType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.LineCapValues, DocumentModel.Wordprocessing.LineCapKind>(value);
  }
  
  /// <summary>
  /// cmpd, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.Wordprocessing.CompoundLineKind? GetCompound(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues, DocumentModel.Wordprocessing.CompoundLineKind>(openXmlElement?.Compound?.Value);
  }
  
  private static void SetCompound(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement, DocumentModel.Wordprocessing.CompoundLineKind? value)
  {
    openXmlElement.Compound = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.CompoundLineValues, DocumentModel.Wordprocessing.CompoundLineKind>(value);
  }
  
  /// <summary>
  /// algn, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.Wordprocessing.PenAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues, DocumentModel.Wordprocessing.PenAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static void SetAlignment(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement, DocumentModel.Wordprocessing.PenAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PenAlignmentValues, DocumentModel.Wordprocessing.PenAlignmentKind>(value);
  }
  
  private static Boolean? GetNoFillEmpty(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty>();
    return itemElement != null;
  }
  
  private static void SetNoFillEmpty(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2010.Word.NoFillEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.SolidColorFillProperties? GetSolidColorFillProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.SolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSolidColorFillProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement, DocumentModel.Wordprocessing.SolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.SolidColorFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.SolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.GradientFillProperties? GetGradientFillProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.GradientFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGradientFillProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement, DocumentModel.Wordprocessing.GradientFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.GradientFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.GradientFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.PresetLineDashKind? GetPresetLineDashProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DocumentModel.Wordprocessing.PresetLineDashKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetPresetLineDashProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement, DocumentModel.Wordprocessing.PresetLineDashKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties, DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DocumentModel.Wordprocessing.PresetLineDashKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetRoundEmpty(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RoundEmpty>();
    return itemElement != null;
  }
  
  private static void SetRoundEmpty(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.RoundEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2010.Word.RoundEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetBevelEmpty(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.BevelEmpty>();
    return itemElement != null;
  }
  
  private static void SetBevelEmpty(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.BevelEmpty>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2010.Word.BevelEmpty();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Wordprocessing.LineJoinMiterProperties? GetLineJoinMiterProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.LineJoinMiterPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLineJoinMiterProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect openXmlElement, DocumentModel.Wordprocessing.LineJoinMiterProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.LineJoinMiterPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.LineJoinMiterProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.TextOutlineEffect? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TextOutlineEffect();
      value.LineWidth = GetLineWidth(openXmlElement);
      value.CapType = GetCapType(openXmlElement);
      value.Compound = GetCompound(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      value.NoFillEmpty = GetNoFillEmpty(openXmlElement);
      value.SolidColorFillProperties = GetSolidColorFillProperties(openXmlElement);
      value.GradientFillProperties = GetGradientFillProperties(openXmlElement);
      value.PresetLineDashProperties = GetPresetLineDashProperties(openXmlElement);
      value.RoundEmpty = GetRoundEmpty(openXmlElement);
      value.BevelEmpty = GetBevelEmpty(openXmlElement);
      value.LineJoinMiterProperties = GetLineJoinMiterProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TextOutlineEffect? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineWidth(openXmlElement, value?.LineWidth);
      SetCapType(openXmlElement, value?.CapType);
      SetCompound(openXmlElement, value?.Compound);
      SetAlignment(openXmlElement, value?.Alignment);
      SetNoFillEmpty(openXmlElement, value?.NoFillEmpty);
      SetSolidColorFillProperties(openXmlElement, value?.SolidColorFillProperties);
      SetGradientFillProperties(openXmlElement, value?.GradientFillProperties);
      SetPresetLineDashProperties(openXmlElement, value?.PresetLineDashProperties);
      SetRoundEmpty(openXmlElement, value?.RoundEmpty);
      SetBevelEmpty(openXmlElement, value?.BevelEmpty);
      SetLineJoinMiterProperties(openXmlElement, value?.LineJoinMiterProperties);
      return openXmlElement;
    }
    return default;
  }
}
