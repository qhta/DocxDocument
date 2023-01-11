namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageTab Class.
/// </summary>
public static class BackstageTabConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.QualifiedId = new StringValue { Value = value };
      else
        openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  public static void SetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterMso = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeMso = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  public static void SetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  public static void SetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  public static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  public static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetEnabled = new StringValue { Value = value };
      else
        openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Label = new StringValue { Value = value };
      else
        openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetLabel = new StringValue { Value = value };
      else
        openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, Boolean? value)
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
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  public static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Keytip = new StringValue { Value = value };
      else
        openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  public static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetKeytip = new StringValue { Value = value };
      else
        openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// title, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTitle(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.Title?.Value;
  }
  
  public static void SetTitle(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Title = new StringValue { Value = value };
      else
        openXmlElement.Title = null;
  }
  
  /// <summary>
  /// getTitle, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetTitle(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.GetTitle?.Value;
  }
  
  public static void SetGetTitle(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetTitle = new StringValue { Value = value };
      else
        openXmlElement.GetTitle = null;
  }
  
  /// <summary>
  /// columnWidthPercent, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetColumnWidthPercent(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.ColumnWidthPercent?.Value;
  }
  
  public static void SetColumnWidthPercent(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnWidthPercent = value;
  }
  
  /// <summary>
  /// firstColumnMinWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetFirstColumnMinWidth(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.FirstColumnMinWidth?.Value;
  }
  
  public static void SetFirstColumnMinWidth(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstColumnMinWidth = value;
  }
  
  /// <summary>
  /// firstColumnMaxWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetFirstColumnMaxWidth(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.FirstColumnMaxWidth?.Value;
  }
  
  public static void SetFirstColumnMaxWidth(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.FirstColumnMaxWidth = value;
  }
  
  /// <summary>
  /// secondColumnMinWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetSecondColumnMinWidth(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.SecondColumnMinWidth?.Value;
  }
  
  public static void SetSecondColumnMinWidth(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.SecondColumnMinWidth = value;
  }
  
  /// <summary>
  /// secondColumnMaxWidth, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int64? GetSecondColumnMaxWidth(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    return openXmlElement?.SecondColumnMaxWidth?.Value;
  }
  
  public static void SetSecondColumnMaxWidth(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, Int64? value)
  {
    if (openXmlElement != null)
      openXmlElement.SecondColumnMaxWidth = value;
  }
  
  /// <summary>
  /// BackstageGroups.
  /// </summary>
  public static DocumentModel.BackstageGroups? GetBackstageGroups(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageGroupsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageGroups(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, DocumentModel.BackstageGroups? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.BackstageGroupsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroups>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// SimpleGroups.
  /// </summary>
  public static DocumentModel.SimpleGroups? GetSimpleGroups(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups>();
    if (itemElement != null)
      return DocumentModel.OpenXml.SimpleGroupsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSimpleGroups(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement, DocumentModel.SimpleGroups? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.SimpleGroupsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.SimpleGroups>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.BackstageTab? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.BackstageTab();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.GetTitle = GetGetTitle(openXmlElement);
      value.ColumnWidthPercent = GetColumnWidthPercent(openXmlElement);
      value.FirstColumnMinWidth = GetFirstColumnMinWidth(openXmlElement);
      value.FirstColumnMaxWidth = GetFirstColumnMaxWidth(openXmlElement);
      value.SecondColumnMinWidth = GetSecondColumnMinWidth(openXmlElement);
      value.SecondColumnMaxWidth = GetSecondColumnMaxWidth(openXmlElement);
      value.BackstageGroups = GetBackstageGroups(openXmlElement);
      value.SimpleGroups = GetSimpleGroups(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.BackstageTab? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.BackstageTab, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
