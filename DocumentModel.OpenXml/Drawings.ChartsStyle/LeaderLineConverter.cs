namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the LeaderLine Class.
/// </summary>
public static class LeaderLineConverter
{
  public static DocumentModel.Drawings.ChartsStyle.LineReference? GetLineReference(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.LineReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLineReference(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement, DocumentModel.Drawings.ChartsStyle.LineReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.LineReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static String? GetLineWidthScale(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetLineWidthScale(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LineWidthScale { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.FillReference? GetFillReference(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.FillReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFillReference(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement, DocumentModel.Drawings.ChartsStyle.FillReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.FillReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FillReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.EffectReference? GetEffectReference(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.EffectReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectReference(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement, DocumentModel.Drawings.ChartsStyle.EffectReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.EffectReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.EffectReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.FontReference? GetFontReference(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.FontReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFontReference(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement, DocumentModel.Drawings.ChartsStyle.FontReference? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.FontReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement, DocumentModel.Drawings.ChartsStyle.ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesType? GetTextCharacterPropertiesType(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.TextCharacterPropertiesTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextCharacterPropertiesType(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement, DocumentModel.Drawings.ChartsStyle.TextCharacterPropertiesType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.TextCharacterPropertiesTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextCharacterPropertiesType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.TextBodyProperties? GetTextBodyProperties(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.TextBodyPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextBodyProperties(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement, DocumentModel.Drawings.ChartsStyle.TextBodyProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.TextBodyPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.TextBodyProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement, DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.LeaderLine? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.LeaderLine();
      value.LineReference = GetLineReference(openXmlElement);
      value.LineWidthScale = GetLineWidthScale(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TextCharacterPropertiesType = GetTextCharacterPropertiesType(openXmlElement);
      value.TextBodyProperties = GetTextBodyProperties(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.LeaderLine? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.LeaderLine, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineReference(openXmlElement, value?.LineReference);
      SetLineWidthScale(openXmlElement, value?.LineWidthScale);
      SetFillReference(openXmlElement, value?.FillReference);
      SetEffectReference(openXmlElement, value?.EffectReference);
      SetFontReference(openXmlElement, value?.FontReference);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTextCharacterPropertiesType(openXmlElement, value?.TextCharacterPropertiesType);
      SetTextBodyProperties(openXmlElement, value?.TextBodyProperties);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
