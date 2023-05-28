namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Presentation Layout Variables.
/// </summary>
public static class PresentationLayoutVariablesConverter
{
  private static Boolean? GetOrganizationChart(DXDD.PresentationLayoutVariables openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDD.OrganizationChart>() != null;
  }
  
  private static bool CmpOrganizationChart(DXDD.PresentationLayoutVariables openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDD.OrganizationChart>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDD.OrganizationChart", val, value);
    return false;
  }
  
  private static void SetOrganizationChart(DXDD.PresentationLayoutVariables openXmlElement, Boolean? value)
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
  
  private static Int32? GetMaxNumberOfChildren(DXDD.PresentationLayoutVariables openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDD.MaxNumberOfChildren>()?.Val);
  }
  
  private static bool CmpMaxNumberOfChildren(DXDD.PresentationLayoutVariables openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDD.MaxNumberOfChildren>()?.Val, value, diffs, objName, "MaxNumberOfChildren");
  }
  
  private static void SetMaxNumberOfChildren(DXDD.PresentationLayoutVariables openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDD.MaxNumberOfChildren,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetPreferredNumberOfChildren(DXDD.PresentationLayoutVariables openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDD.PreferredNumberOfChildren>()?.Val);
  }
  
  private static bool CmpPreferredNumberOfChildren(DXDD.PresentationLayoutVariables openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDD.PreferredNumberOfChildren>()?.Val, value, diffs, objName, "PreferredNumberOfChildren");
  }
  
  private static void SetPreferredNumberOfChildren(DXDD.PresentationLayoutVariables openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDD.PreferredNumberOfChildren,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean? GetBulletEnabled(DXDD.PresentationLayoutVariables openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDD.BulletEnabled>() != null;
  }
  
  private static bool CmpBulletEnabled(DXDD.PresentationLayoutVariables openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXDD.BulletEnabled>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDD.BulletEnabled", val, value);
    return false;
  }
  
  private static void SetBulletEnabled(DXDD.PresentationLayoutVariables openXmlElement, Boolean? value)
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
  
  private static DMDD.DirectionKind? GetDirection(DXDD.PresentationLayoutVariables openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDD.DirectionKind>(openXmlElement.GetFirstChild<DXDD.Direction>()?.Val?.Value);
  }
  
  private static bool CmpDirection(DXDD.PresentationLayoutVariables openXmlElement, DMDD.DirectionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDD.DirectionKind>(openXmlElement.GetFirstChild<DXDD.Direction>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetDirection(DXDD.PresentationLayoutVariables openXmlElement, DMDD.DirectionKind? value)
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
  
  private static DMDD.HierarchyBranchStyleKind? GetHierarchyBranch(DXDD.PresentationLayoutVariables openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDD.HierarchyBranchStyleKind>(openXmlElement.GetFirstChild<DXDD.HierarchyBranch>()?.Val?.Value);
  }
  
  private static bool CmpHierarchyBranch(DXDD.PresentationLayoutVariables openXmlElement, DMDD.HierarchyBranchStyleKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDD.HierarchyBranchStyleKind>(openXmlElement.GetFirstChild<DXDD.HierarchyBranch>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetHierarchyBranch(DXDD.PresentationLayoutVariables openXmlElement, DMDD.HierarchyBranchStyleKind? value)
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
  
  private static DMDD.AnimateOneByOneKind? GetAnimateOneByOne(DXDD.PresentationLayoutVariables openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDD.AnimateOneByOneKind>(openXmlElement.GetFirstChild<DXDD.AnimateOneByOne>()?.Val?.Value);
  }
  
  private static bool CmpAnimateOneByOne(DXDD.PresentationLayoutVariables openXmlElement, DMDD.AnimateOneByOneKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDD.AnimateOneByOneKind>(openXmlElement.GetFirstChild<DXDD.AnimateOneByOne>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAnimateOneByOne(DXDD.PresentationLayoutVariables openXmlElement, DMDD.AnimateOneByOneKind? value)
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
  
  private static DMDD.AnimationLevelStringKind? GetAnimationLevel(DXDD.PresentationLayoutVariables openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDD.AnimationLevelStringKind>(openXmlElement.GetFirstChild<DXDD.AnimationLevel>()?.Val?.Value);
  }
  
  private static bool CmpAnimationLevel(DXDD.PresentationLayoutVariables openXmlElement, DMDD.AnimationLevelStringKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDD.AnimationLevelStringKind>(openXmlElement.GetFirstChild<DXDD.AnimationLevel>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAnimationLevel(DXDD.PresentationLayoutVariables openXmlElement, DMDD.AnimationLevelStringKind? value)
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
  
  private static DMDD.ResizeHandlesStringKind? GetResizeHandles(DXDD.PresentationLayoutVariables openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDD.ResizeHandlesStringKind>(openXmlElement.GetFirstChild<DXDD.ResizeHandles>()?.Val?.Value);
  }
  
  private static bool CmpResizeHandles(DXDD.PresentationLayoutVariables openXmlElement, DMDD.ResizeHandlesStringKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDD.ResizeHandlesStringKind>(openXmlElement.GetFirstChild<DXDD.ResizeHandles>()?.Val?.Value, value, diffs, objName, propName);
  }
  
  private static void SetResizeHandles(DXDD.PresentationLayoutVariables openXmlElement, DMDD.ResizeHandlesStringKind? value)
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
  
  public static DMDD.PresentationLayoutVariables? CreateModelElement(DXDD.PresentationLayoutVariables? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDD.PresentationLayoutVariables();
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
  
  public static bool CompareModelElement(DXDD.PresentationLayoutVariables? openXmlElement, DMDD.PresentationLayoutVariables? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOrganizationChart(openXmlElement, value.OrganizationChart, diffs, objName, propName))
        ok = false;
      if (!CmpMaxNumberOfChildren(openXmlElement, value.MaxNumberOfChildren, diffs, objName, propName))
        ok = false;
      if (!CmpPreferredNumberOfChildren(openXmlElement, value.PreferredNumberOfChildren, diffs, objName, propName))
        ok = false;
      if (!CmpBulletEnabled(openXmlElement, value.BulletEnabled, diffs, objName, propName))
        ok = false;
      if (!CmpDirection(openXmlElement, value.Direction, diffs, objName, propName))
        ok = false;
      if (!CmpHierarchyBranch(openXmlElement, value.HierarchyBranch, diffs, objName, propName))
        ok = false;
      if (!CmpAnimateOneByOne(openXmlElement, value.AnimateOneByOne, diffs, objName, propName))
        ok = false;
      if (!CmpAnimationLevel(openXmlElement, value.AnimationLevel, diffs, objName, propName))
        ok = false;
      if (!CmpResizeHandles(openXmlElement, value.ResizeHandles, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDD.PresentationLayoutVariables value)
    where OpenXmlElementType: DXDD.PresentationLayoutVariables, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDD.PresentationLayoutVariables openXmlElement, DMDD.PresentationLayoutVariables value)
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
