namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Dash Stop.
/// </summary>
public static class DashStopConverter
{
  /// <summary>
  /// Dash Length
  /// </summary>
  public static Int32? GetDashLength(DocumentFormat.OpenXml.Drawing.DashStop? openXmlElement)
  {
    return openXmlElement?.DashLength?.Value;
  }
  
  public static void SetDashLength(DocumentFormat.OpenXml.Drawing.DashStop? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.DashLength = value;
  }
  
  /// <summary>
  /// Space Length
  /// </summary>
  public static Int32? GetSpaceLength(DocumentFormat.OpenXml.Drawing.DashStop? openXmlElement)
  {
    return openXmlElement?.SpaceLength?.Value;
  }
  
  public static void SetSpaceLength(DocumentFormat.OpenXml.Drawing.DashStop? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SpaceLength = value;
  }
  
  public static DocumentModel.Drawings.DashStop? CreateModelElement(DocumentFormat.OpenXml.Drawing.DashStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.DashStop();
      value.DashLength = GetDashLength(openXmlElement);
      value.SpaceLength = GetSpaceLength(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.DashStop? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.DashStop, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
