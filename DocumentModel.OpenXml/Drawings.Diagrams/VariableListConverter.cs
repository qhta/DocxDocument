namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Variable List.
/// </summary>
public static class VariableListConverter
{
  private static Boolean? GetOrganizationChart(DXDD.VariableList openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDD.OrganizationChart>() != null;
  }
  
  private static bool CmpOrganizationChart(DXDD.VariableList openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDD.OrganizationChart>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDD.OrganizationChart", val, value);
    return false;
  }
  
  private static void SetOrganizationChart(DXDD.VariableList openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDD.OrganizationChart>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDD.OrganizationChart();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Int32? GetMaxNumberOfChildren(DXDD.VariableList openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDD.MaxNumberOfChildren>()?.Val);
  }
  
  private static bool CmpMaxNumberOfChildren(DXDD.VariableList openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDD.MaxNumberOfChildren>()?.Val, value, diffs, objName, "MaxNumberOfChildren");
  }
  
  private static void SetMaxNumberOfChildren(DXDD.VariableList openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDD.MaxNumberOfChildren,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetPreferredNumberOfChildren(DXDD.VariableList openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDD.PreferredNumberOfChildren>()?.Val);
  }
  
  private static bool CmpPreferredNumberOfChildren(DXDD.VariableList openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDD.PreferredNumberOfChildren>()?.Val, value, diffs, objName, "PreferredNumberOfChildren");
  }
  
  private static void SetPreferredNumberOfChildren(DXDD.VariableList openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDD.PreferredNumberOfChildren,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean? GetBulletEnabled(DXDD.VariableList openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDD.BulletEnabled>() != null;
  }
  
  private static bool CmpBulletEnabled(DXDD.VariableList openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDD.BulletEnabled>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDD.BulletEnabled", val, value);
    return false;
  }
  
  private static void SetBulletEnabled(DXDD.VariableList openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDD.BulletEnabled>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDD.BulletEnabled();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDD.DirectionKind? GetDirection(DXDD.VariableList openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDD.DirectionKind>(openXmlElement.GetFirstChild<DXDD.Direction>()?.Val?.Value);
  }
  
  private static bool CmpDirection(DXDD.VariableList openXmlElement, DMDD.DirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDD.DirectionKind>(openXmlElement.GetFirstChild<DXDD.Direction>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetDirection(DXDD.VariableList openXmlElement, DMDD.DirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.Direction>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDD.DirectionKind>(itemElement, (DMDD.DirectionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDD.Direction, DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDD.DirectionKind>((DMDD.DirectionKind)value));
  }
  
  private static DMDD.HierarchyBranchStyleKind? GetHierarchyBranch(DXDD.VariableList openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDD.HierarchyBranchStyleKind>(openXmlElement.GetFirstChild<DXDD.HierarchyBranch>()?.Val?.Value);
  }
  
  private static bool CmpHierarchyBranch(DXDD.VariableList openXmlElement, DMDD.HierarchyBranchStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDD.HierarchyBranchStyleKind>(openXmlElement.GetFirstChild<DXDD.HierarchyBranch>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHierarchyBranch(DXDD.VariableList openXmlElement, DMDD.HierarchyBranchStyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.HierarchyBranch>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDD.HierarchyBranchStyleKind>(itemElement, (DMDD.HierarchyBranchStyleKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDD.HierarchyBranch, DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDD.HierarchyBranchStyleKind>((DMDD.HierarchyBranchStyleKind)value));
  }
  
  private static DMDD.AnimateOneByOneKind? GetAnimateOneByOne(DXDD.VariableList openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDD.AnimateOneByOneKind>(openXmlElement.GetFirstChild<DXDD.AnimateOneByOne>()?.Val?.Value);
  }
  
  private static bool CmpAnimateOneByOne(DXDD.VariableList openXmlElement, DMDD.AnimateOneByOneKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDD.AnimateOneByOneKind>(openXmlElement.GetFirstChild<DXDD.AnimateOneByOne>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetAnimateOneByOne(DXDD.VariableList openXmlElement, DMDD.AnimateOneByOneKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.AnimateOneByOne>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDD.AnimateOneByOneKind>(itemElement, (DMDD.AnimateOneByOneKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDD.AnimateOneByOne, DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDD.AnimateOneByOneKind>((DMDD.AnimateOneByOneKind)value));
  }
  
  private static DMDD.AnimationLevelStringKind? GetAnimationLevel(DXDD.VariableList openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDD.AnimationLevelStringKind>(openXmlElement.GetFirstChild<DXDD.AnimationLevel>()?.Val?.Value);
  }
  
  private static bool CmpAnimationLevel(DXDD.VariableList openXmlElement, DMDD.AnimationLevelStringKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDD.AnimationLevelStringKind>(openXmlElement.GetFirstChild<DXDD.AnimationLevel>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetAnimationLevel(DXDD.VariableList openXmlElement, DMDD.AnimationLevelStringKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.AnimationLevel>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDD.AnimationLevelStringKind>(itemElement, (DMDD.AnimationLevelStringKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDD.AnimationLevel, DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDD.AnimationLevelStringKind>((DMDD.AnimationLevelStringKind)value));
  }
  
  private static DMDD.ResizeHandlesStringKind? GetResizeHandles(DXDD.VariableList openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDD.ResizeHandlesStringKind>(openXmlElement.GetFirstChild<DXDD.ResizeHandles>()?.Val?.Value);
  }
  
  private static bool CmpResizeHandles(DXDD.VariableList openXmlElement, DMDD.ResizeHandlesStringKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDD.ResizeHandlesStringKind>(openXmlElement.GetFirstChild<DXDD.ResizeHandles>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetResizeHandles(DXDD.VariableList openXmlElement, DMDD.ResizeHandlesStringKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDD.ResizeHandles>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDD.ResizeHandlesStringKind>(itemElement, (DMDD.ResizeHandlesStringKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXDD.ResizeHandles, DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDD.ResizeHandlesStringKind>((DMDD.ResizeHandlesStringKind)value));
  }
  
  public static DocumentModel.Drawings.Diagrams.VariableList? CreateModelElement(DXDD.VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.VariableList();
      value.OrganizationChart = GetOrganizationChart(openXmlElement);
      value.MaxNumberOfChildren = GetMaxNumberOfChildren(openXmlElement);
      value.PreferredNumberOfChildren = GetPreferredNumberOfChildren(openXmlElement);
      value.BulletEnabled = GetBulletEnabled(openXmlElement);
      value.Direction = GetDirection(openXmlElement);
      value.HierarchyBranch = GetHierarchyBranch(openXmlElement);
      value.AnimateOneByOne = GetAnimateOneByOne(openXmlElement);
      value.AnimationLevel = GetAnimationLevel(openXmlElement);
      value.ResizeHandles = GetResizeHandles(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDD.VariableList? openXmlElement, DMDD.VariableList? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOrganizationChart(openXmlElement, value.OrganizationChart, diffs, objName))
        ok = false;
      if (!CmpMaxNumberOfChildren(openXmlElement, value.MaxNumberOfChildren, diffs, objName))
        ok = false;
      if (!CmpPreferredNumberOfChildren(openXmlElement, value.PreferredNumberOfChildren, diffs, objName))
        ok = false;
      if (!CmpBulletEnabled(openXmlElement, value.BulletEnabled, diffs, objName))
        ok = false;
      if (!CmpDirection(openXmlElement, value.Direction, diffs, objName))
        ok = false;
      if (!CmpHierarchyBranch(openXmlElement, value.HierarchyBranch, diffs, objName))
        ok = false;
      if (!CmpAnimateOneByOne(openXmlElement, value.AnimateOneByOne, diffs, objName))
        ok = false;
      if (!CmpAnimationLevel(openXmlElement, value.AnimationLevel, diffs, objName))
        ok = false;
      if (!CmpResizeHandles(openXmlElement, value.ResizeHandles, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.VariableList value)
    where OpenXmlElementType: DXDD.VariableList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.VariableList openXmlElement, DMDD.VariableList value)
  {
    SetOrganizationChart(openXmlElement, value?.OrganizationChart);
    SetMaxNumberOfChildren(openXmlElement, value?.MaxNumberOfChildren);
    SetPreferredNumberOfChildren(openXmlElement, value?.PreferredNumberOfChildren);
    SetBulletEnabled(openXmlElement, value?.BulletEnabled);
    SetDirection(openXmlElement, value?.Direction);
    SetHierarchyBranch(openXmlElement, value?.HierarchyBranch);
    SetAnimateOneByOne(openXmlElement, value?.AnimateOneByOne);
    SetAnimationLevel(openXmlElement, value?.AnimationLevel);
    SetResizeHandles(openXmlElement, value?.ResizeHandles);
  }
}
