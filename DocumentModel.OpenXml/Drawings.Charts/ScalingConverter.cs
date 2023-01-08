namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Scaling.
/// </summary>
public static class ScalingConverter
{
  /// <summary>
  /// Axis Orientation.
  /// </summary>
  public static DocumentModel.Drawings.Charts.OrientationKind? GetOrientation(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Orientation>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DocumentModel.Drawings.Charts.OrientationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetOrientation(DocumentFormat.OpenXml.Drawing.Charts.Scaling? openXmlElement, DocumentModel.Drawings.Charts.OrientationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Orientation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Orientation, DocumentFormat.OpenXml.Drawing.Charts.OrientationValues, DocumentModel.Drawings.Charts.OrientationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
