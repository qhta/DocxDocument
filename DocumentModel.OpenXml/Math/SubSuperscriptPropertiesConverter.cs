namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Sub-Superscript Properties.
/// </summary>
public static class SubSuperscriptPropertiesConverter
{
  /// <summary>
  /// Align Scripts.
  /// </summary>
  public static DocumentModel.Math.BooleanKind? GetAlignScripts(DocumentFormat.OpenXml.Math.SubSuperscriptProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.AlignScripts>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetAlignScripts(DocumentFormat.OpenXml.Math.SubSuperscriptProperties? openXmlElement, DocumentModel.Math.BooleanKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.AlignScripts>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.AlignScripts, DocumentFormat.OpenXml.Math.BooleanValues, DocumentModel.Math.BooleanKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
