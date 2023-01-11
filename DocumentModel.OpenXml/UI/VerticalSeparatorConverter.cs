namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the VerticalSeparator Class.
/// </summary>
public static class VerticalSeparatorConverter
{
  /// <summary>
  /// id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  public static String? GetIdQ(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  public static void SetIdQ(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdQ = new StringValue { Value = value };
      else
        openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterMso = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeMso = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public static String? GetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  public static void SetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterQ = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public static String? GetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  public static void SetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQ = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQ = null;
  }
  
  public static DocumentModel.UI.VerticalSeparator? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.VerticalSeparator();
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQ = GetInsertAfterQ(openXmlElement);
      value.InsertBeforeQ = GetInsertBeforeQ(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.VerticalSeparator? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.VerticalSeparator, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
