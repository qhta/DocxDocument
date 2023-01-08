namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Pie of Pie or Bar of Pie Charts.
/// </summary>
public static class OfPieChartConverter
{
  /// <summary>
  /// Pie of Pie or Bar of Pie Type.
  /// </summary>
  public static DocumentModel.Drawings.Charts.OfPieKind? GetOfPieType(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OfPieType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DocumentModel.Drawings.Charts.OfPieKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetOfPieType(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, DocumentModel.Drawings.Charts.OfPieKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.OfPieType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.OfPieType, DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DocumentModel.Drawings.Charts.OfPieKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.SplitKind? GetSplitType(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SplitType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DocumentModel.Drawings.Charts.SplitKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetSplitType(DocumentFormat.OpenXml.Drawing.Charts.OfPieChart? openXmlElement, DocumentModel.Drawings.Charts.SplitKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SplitType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SplitType, DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DocumentModel.Drawings.Charts.SplitKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
