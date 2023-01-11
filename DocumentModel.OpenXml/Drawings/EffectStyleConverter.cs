namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect Style.
/// </summary>
public static class EffectStyleConverter
{
  public static DocumentModel.Drawings.EffectList? GetEffectList(DocumentFormat.OpenXml.Drawing.EffectStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectList(DocumentFormat.OpenXml.Drawing.EffectStyle? openXmlElement, DocumentModel.Drawings.EffectList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.EffectListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.EffectDag? GetEffectDag(DocumentFormat.OpenXml.Drawing.EffectStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectDagConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectDag(DocumentFormat.OpenXml.Drawing.EffectStyle? openXmlElement, DocumentModel.Drawings.EffectDag? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.EffectDagConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.EffectDag>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Scene3DType? GetScene3DType(DocumentFormat.OpenXml.Drawing.EffectStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Scene3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetScene3DType(DocumentFormat.OpenXml.Drawing.EffectStyle? openXmlElement, DocumentModel.Drawings.Scene3DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Scene3DType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Scene3DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Scene3DType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Shape3DType? GetShape3DType(DocumentFormat.OpenXml.Drawing.EffectStyle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Shape3DTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShape3DType(DocumentFormat.OpenXml.Drawing.EffectStyle? openXmlElement, DocumentModel.Drawings.Shape3DType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Shape3DType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Shape3DTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Shape3DType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.EffectStyle? CreateModelElement(DocumentFormat.OpenXml.Drawing.EffectStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.EffectStyle();
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      value.Scene3DType = GetScene3DType(openXmlElement);
      value.Shape3DType = GetShape3DType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.EffectStyle? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.EffectStyle, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
