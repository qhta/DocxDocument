namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TextOutlineEffect Class.
/// </summary>
public static class TextOutlineEffectConverter
{
  public static DocumentModel.Wordprocessing.PresetLineDashKind? GetPresetLineDashProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashProperties>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetLineDashValues, DocumentModel.Wordprocessing.PresetLineDashKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetPresetLineDashProperties(DocumentFormat.OpenXml.Office2010.Word.TextOutlineEffect? openXmlElement, DocumentModel.Wordprocessing.PresetLineDashKind? value)
  {
    if (openXmlElement != null)
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
  }
  
}
