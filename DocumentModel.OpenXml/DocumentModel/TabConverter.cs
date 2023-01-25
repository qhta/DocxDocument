namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Tab Class.
/// </summary>
public static class TabConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.QualifiedId?.Value == value;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Tag?.Value == value;
  }
  
  private static void SetTag(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.IdMso?.Value == value;
  }
  
  private static void SetIdMso(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Label?.Value == value;
  }
  
  private static void SetLabel(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetLabel?.Value == value;
  }
  
  private static void SetGetLabel(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertAfterMso?.Value == value;
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertBeforeMso?.Value == value;
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value == value;
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value == value;
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.Tab openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Visible?.Value == value;
  }
  
  private static void SetVisible(DXO2010CustUI.Tab openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetVisible?.Value == value;
  }
  
  private static void SetGetVisible(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static bool CmpKeytip(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Keytip?.Value == value;
  }
  
  private static void SetKeytip(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO2010CustUI.Tab openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static bool CmpGetKeytip(DXO2010CustUI.Tab openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetKeytip?.Value == value;
  }
  
  private static void SetGetKeytip(DXO2010CustUI.Tab openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  private static DM.Group? GetGroup(DXO2010CustUI.Tab openXmlElement)
  {
    return DMX.GroupConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Group>());
  }
  
  private static bool CmpGroup(DXO2010CustUI.Tab openXmlElement, DM.Group? value, DiffList? diffs, string? objName)
  {
    return DMX.GroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Group>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGroup(DXO2010CustUI.Tab openXmlElement, DM.Group? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Group>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.GroupConverter.CreateOpenXmlElement<DXO2010CustUI.Group>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.Tab? CreateModelElement(DXO2010CustUI.Tab? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.Tab();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.Group = GetGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.Tab? openXmlElement, DM.Tab? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpQualifiedId(openXmlElement, value.QualifiedId, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName))
        ok = false;
      if (!CmpInsertAfterMso(openXmlElement, value.InsertAfterMso, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeMso(openXmlElement, value.InsertBeforeMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterQulifiedId(openXmlElement, value.InsertAfterQulifiedId, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQulifiedId(openXmlElement, value.InsertBeforeQulifiedId, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpKeytip(openXmlElement, value.Keytip, diffs, objName))
        ok = false;
      if (!CmpGetKeytip(openXmlElement, value.GetKeytip, diffs, objName))
        ok = false;
      if (!CmpGroup(openXmlElement, value.Group, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.Tab? value)
    where OpenXmlElementType: DXO2010CustUI.Tab, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetIdMso(openXmlElement, value?.IdMso);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
      SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
      SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
      SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetKeytip(openXmlElement, value?.Keytip);
      SetGetKeytip(openXmlElement, value?.GetKeytip);
      SetGroup(openXmlElement, value?.Group);
      return openXmlElement;
    }
    return default;
  }
}
