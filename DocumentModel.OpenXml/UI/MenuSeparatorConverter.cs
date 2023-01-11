namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the MenuSeparator Class.
/// </summary>
public static class MenuSeparatorConverter
{
  /// <summary>
  /// id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement, String? value)
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
  public static String? GetIdQ(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  public static void SetIdQ(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdQ = new StringValue { Value = value };
      else
        openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement, String? value)
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
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement, String? value)
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
  public static String? GetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  public static void SetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement, String? value)
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
  public static String? GetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  public static void SetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQ = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// title
  /// </summary>
  public static String? GetTitle(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }
  
  /// <summary>
  /// getTitle
  /// </summary>
  public static String? GetGetTitle(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement)
  {
    return openXmlElement?.GetTitle?.Value;
  }
  
  public static void SetGetTitle(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetTitle = new StringValue { Value = value };
      else
        openXmlElement.GetTitle = null;
  }
  
  public static DocumentModel.UI.MenuSeparator? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.MenuSeparator();
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQ = GetInsertAfterQ(openXmlElement);
      value.InsertBeforeQ = GetInsertBeforeQ(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.GetTitle = GetGetTitle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.MenuSeparator? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.MenuSeparator, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
