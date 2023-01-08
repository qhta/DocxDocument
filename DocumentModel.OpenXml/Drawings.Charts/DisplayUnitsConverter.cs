namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DisplayUnits Class.
/// </summary>
public static class DisplayUnitsConverter
{
  public static DocumentModel.Drawings.Charts.BuiltInUnitKind? GetBuiltInUnit(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DocumentModel.Drawings.Charts.BuiltInUnitKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetBuiltInUnit(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits? openXmlElement, DocumentModel.Drawings.Charts.BuiltInUnitKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnit, DocumentFormat.OpenXml.Drawing.Charts.BuiltInUnitValues, DocumentModel.Drawings.Charts.BuiltInUnitKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
