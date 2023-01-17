namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the CategoryAxisData Class.
/// </summary>
public static class CategoryAxisDataConverter
{
  private static DocumentModel.Drawings.Charts.MultiLevelStringReference? GetMultiLevelStringReference(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.MultiLevelStringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMultiLevelStringReference(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData openXmlElement, DocumentModel.Drawings.Charts.MultiLevelStringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.MultiLevelStringReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MultiLevelStringReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.NumberReference? GetNumberReference(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberReference(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData openXmlElement, DocumentModel.Drawings.Charts.NumberReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.NumberReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.NumberLiteral? GetNumberLiteral(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.NumberLiteralConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberLiteral(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData openXmlElement, DocumentModel.Drawings.Charts.NumberLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.NumberLiteralConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.StringReference? GetStringReference(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.StringReferenceConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringReference(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData openXmlElement, DocumentModel.Drawings.Charts.StringReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.StringReferenceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.StringLiteral? GetStringLiteral(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.StringLiteralConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetStringLiteral(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData openXmlElement, DocumentModel.Drawings.Charts.StringLiteral? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.StringLiteralConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.StringLiteral>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.CategoryAxisData? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryAxisData();
      value.MultiLevelStringReference = GetMultiLevelStringReference(openXmlElement);
      value.NumberReference = GetNumberReference(openXmlElement);
      value.NumberLiteral = GetNumberLiteral(openXmlElement);
      value.StringReference = GetStringReference(openXmlElement);
      value.StringLiteral = GetStringLiteral(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.CategoryAxisData? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.CategoryAxisData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMultiLevelStringReference(openXmlElement, value?.MultiLevelStringReference);
      SetNumberReference(openXmlElement, value?.NumberReference);
      SetNumberLiteral(openXmlElement, value?.NumberLiteral);
      SetStringReference(openXmlElement, value?.StringReference);
      SetStringLiteral(openXmlElement, value?.StringLiteral);
      return openXmlElement;
    }
    return default;
  }
}
