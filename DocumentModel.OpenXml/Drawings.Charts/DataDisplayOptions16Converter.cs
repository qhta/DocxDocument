namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataDisplayOptions16 Class.
/// </summary>
public static class DataDisplayOptions16Converter
{
  /// <summary>
  /// BooleanFalse.
  /// </summary>
  public static Boolean? GetBooleanFalse(DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBooleanFalse(DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office2019.Drawing.Chart.BooleanFalse();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataDisplayOptions16? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DataDisplayOptions16();
      value.BooleanFalse = GetBooleanFalse(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DataDisplayOptions16? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.DataDisplayOptions16, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
