namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the ContextualTabSet Class.
/// </summary>
public static class ContextualTabSetConverter
{
  /// <summary>
  /// idMso
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  public static void SetIdMso(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet? openXmlElement, Boolean? value)
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
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.UI.Tab>? GetTabs(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.UI.Tab>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office.CustomUI.Tab>())
      {
        var newItem = DocumentModel.OpenXml.UI.TabConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetTabs(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.UI.Tab>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office.CustomUI.Tab>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.UI.TabConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Tab>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.UI.ContextualTabSet? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.ContextualTabSet();
      value.IdMso = GetIdMso(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Tabs = GetTabs(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.ContextualTabSet? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSet, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIdMso(openXmlElement, value?.IdMso);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      return openXmlElement;
    }
    return default;
  }
}
