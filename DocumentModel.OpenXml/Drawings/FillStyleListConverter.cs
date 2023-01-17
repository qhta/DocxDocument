namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Fill Style List.
/// </summary>
public static class FillStyleListConverter
{
  private static Boolean? GetNoFill(DocumentFormat.OpenXml.Drawing.FillStyleList openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NoFill>();
    return itemElement != null;
  }
  
  private static void SetNoFill(DocumentFormat.OpenXml.Drawing.FillStyleList openXmlElement, Boolean? value)
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
  
  private static DocumentModel.Drawings.SolidFill? GetSolidFill(DocumentFormat.OpenXml.Drawing.FillStyleList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SolidFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SolidFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSolidFill(DocumentFormat.OpenXml.Drawing.FillStyleList openXmlElement, DocumentModel.Drawings.SolidFill? value)
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
  
  private static DocumentModel.Drawings.GradientFill? GetGradientFill(DocumentFormat.OpenXml.Drawing.FillStyleList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.GradientFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.GradientFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGradientFill(DocumentFormat.OpenXml.Drawing.FillStyleList openXmlElement, DocumentModel.Drawings.GradientFill? value)
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
  
  private static DocumentModel.Drawings.BlipFill? GetBlipFill(DocumentFormat.OpenXml.Drawing.FillStyleList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BlipFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBlipFill(DocumentFormat.OpenXml.Drawing.FillStyleList openXmlElement, DocumentModel.Drawings.BlipFill? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BlipFill>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BlipFillConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BlipFill>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.PatternFill? GetPatternFill(DocumentFormat.OpenXml.Drawing.FillStyleList openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PatternFill>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PatternFillConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPatternFill(DocumentFormat.OpenXml.Drawing.FillStyleList openXmlElement, DocumentModel.Drawings.PatternFill? value)
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
  
  private static Boolean? GetGroupFill(DocumentFormat.OpenXml.Drawing.FillStyleList openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
    return itemElement != null;
  }
  
  private static void SetGroupFill(DocumentFormat.OpenXml.Drawing.FillStyleList openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.GroupFill();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.FillStyleList? CreateModelElement(DocumentFormat.OpenXml.Drawing.FillStyleList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.FillStyleList();
      value.NoFill = GetNoFill(openXmlElement);
      value.SolidFill = GetSolidFill(openXmlElement);
      value.GradientFill = GetGradientFill(openXmlElement);
      value.BlipFill = GetBlipFill(openXmlElement);
      value.PatternFill = GetPatternFill(openXmlElement);
      value.GroupFill = GetGroupFill(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.FillStyleList? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.FillStyleList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNoFill(openXmlElement, value?.NoFill);
      SetSolidFill(openXmlElement, value?.SolidFill);
      SetGradientFill(openXmlElement, value?.GradientFill);
      SetBlipFill(openXmlElement, value?.BlipFill);
      SetPatternFill(openXmlElement, value?.PatternFill);
      SetGroupFill(openXmlElement, value?.GroupFill);
      return openXmlElement;
    }
    return default;
  }
}
