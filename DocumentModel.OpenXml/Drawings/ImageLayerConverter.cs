namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the ImageLayer Class.
/// </summary>
public static class ImageLayerConverter
{
  /// <summary>
  /// embed, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetEmbed(DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer? openXmlElement)
  {
    return openXmlElement?.Embed?.Value;
  }
  
  public static void SetEmbed(DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Embed = new StringValue { Value = value };
      else
        openXmlElement.Embed = null;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ImageEffect>? GetImageEffects(DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ImageEffect>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.ImageEffectConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetImageEffects(DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ImageEffect>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.ImageEffectConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.ImageEffect>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.ImageLayer? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ImageLayer();
      value.Embed = GetEmbed(openXmlElement);
      value.ImageEffects = GetImageEffects(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ImageLayer? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
