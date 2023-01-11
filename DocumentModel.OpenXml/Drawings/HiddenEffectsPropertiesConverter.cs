namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenEffectsProperties Class.
/// </summary>
public static class HiddenEffectsPropertiesConverter
{
  /// <summary>
  /// Effect Container.
  /// </summary>
  public static DocumentModel.Drawings.EffectList? GetEffectList(DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectList(DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties? openXmlElement, DocumentModel.Drawings.EffectList? value)
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
  
  /// <summary>
  /// Effect Container.
  /// </summary>
  public static DocumentModel.Drawings.EffectDag? GetEffectDag(DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.EffectDag>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.EffectDagConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetEffectDag(DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties? openXmlElement, DocumentModel.Drawings.EffectDag? value)
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
  
  public static DocumentModel.Drawings.HiddenEffectsProperties? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.HiddenEffectsProperties();
      value.EffectList = GetEffectList(openXmlElement);
      value.EffectDag = GetEffectDag(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.HiddenEffectsProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.HiddenEffectsProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
