namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Header and Footer.
/// </summary>
public static class HeaderShapeDefaultsConverter
{
  public static DocumentModel.Vml.ShapeDefaults? GetShapeDefaults(DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeDefaults>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapeDefaultsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeDefaults(DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults? openXmlElement, DocumentModel.Vml.ShapeDefaults? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeDefaults>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ShapeDefaultsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ShapeDefaults>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Vml.ShapeLayout? GetShapeLayout(DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeLayout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Vml.ShapeLayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeLayout(DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults? openXmlElement, DocumentModel.Vml.ShapeLayout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ShapeLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Vml.ShapeLayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Vml.Office.ShapeLayout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.HeaderShapeDefaults? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.HeaderShapeDefaults();
      value.ShapeDefaults = GetShapeDefaults(openXmlElement);
      value.ShapeLayout = GetShapeLayout(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.HeaderShapeDefaults? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.HeaderShapeDefaults, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
