namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the HiddenLineProperties Class.
/// </summary>
public static class HiddenLinePropertiesConverter
{
  public static DocumentModel.Drawings.PresetLineDashKind? GetPresetDash(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DocumentModel.Drawings.PresetLineDashKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetPresetDash(DocumentFormat.OpenXml.Office2010.Drawing.HiddenLineProperties? openXmlElement, DocumentModel.Drawings.PresetLineDashKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetDash>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetDash, DocumentFormat.OpenXml.Drawing.PresetLineDashValues, DocumentModel.Drawings.PresetLineDashKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
