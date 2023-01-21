namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the MenuSeparator Class.
/// </summary>
public static class MenuSeparatorConverter
{
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.MenuSeparator openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXOCustUI.MenuSeparator openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.MenuSeparator openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static void SetIdQ(DXOCustUI.MenuSeparator openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.MenuSeparator openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static void SetInsertAfterMso(DXOCustUI.MenuSeparator openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.MenuSeparator openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.MenuSeparator openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.MenuSeparator openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static void SetInsertAfterQ(DXOCustUI.MenuSeparator openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.MenuSeparator openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.MenuSeparator openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// title
  /// </summary>
  private static String? GetTitle(DXOCustUI.MenuSeparator openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  private static void SetTitle(DXOCustUI.MenuSeparator openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Title = new StringValue { Value = value };
    else
      openXmlElement.Title = null;
  }
  
  /// <summary>
  /// getTitle
  /// </summary>
  private static String? GetGetTitle(DXOCustUI.MenuSeparator openXmlElement)
  {
    return openXmlElement?.GetTitle?.Value;
  }
  
  private static void SetGetTitle(DXOCustUI.MenuSeparator openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetTitle = new StringValue { Value = value };
    else
      openXmlElement.GetTitle = null;
  }
  
  public static DMUI.MenuSeparator? CreateModelElement(DXOCustUI.MenuSeparator? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.MenuSeparator();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.MenuSeparator? value)
    where OpenXmlElementType: DXOCustUI.MenuSeparator, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetIdQ(openXmlElement, value?.IdQ);
      SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
      SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
      SetInsertAfterQ(openXmlElement, value?.InsertAfterQ);
      SetInsertBeforeQ(openXmlElement, value?.InsertBeforeQ);
      SetTitle(openXmlElement, value?.Title);
      SetGetTitle(openXmlElement, value?.GetTitle);
      return openXmlElement;
    }
    return default;
  }
}
