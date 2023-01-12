namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TabSet Class.
/// </summary>
public static class TabSetConverter
{
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  public static void SetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Tab>? GetTabs(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Tab>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>())
      {
        var newItem = DocumentModel.OpenXml.TabConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetTabs(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Tab>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.TabConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Tab>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.TabSet? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.TabSet? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TabSet();
      value.IdMso = GetIdMso(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Tabs = GetTabs(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.TabSet? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.TabSet, new()
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
