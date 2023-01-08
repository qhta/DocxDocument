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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetEmbed(DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ImageEffect>? GetImageEffects(DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetImageEffects(DocumentFormat.OpenXml.Office2010.Drawing.ImageLayer? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ImageEffect>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
