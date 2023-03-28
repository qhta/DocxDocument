namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Variable List converter from/to OpenXml.
///</summary>
public static class VariableListConverter
{
  private static Boolean? GetOrganizationChart(DXDrawDgms.VariableList openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawDgms.OrganizationChart>() != null;
  }
  
  private static bool CmpOrganizationChart(DXDrawDgms.VariableList openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawDgms.OrganizationChart>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawDgms.OrganizationChart", val, value);
    return false;
  }
  
  private static void SetOrganizationChart(DXDrawDgms.VariableList openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.OrganizationChart>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawDgms.OrganizationChart();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Int32? GetMaxNumberOfChildren(DXDrawDgms.VariableList openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawDgms.MaxNumberOfChildren>()?.Val);
  }
  
  private static bool CmpMaxNumberOfChildren(DXDrawDgms.VariableList openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawDgms.MaxNumberOfChildren>()?.Val, value, diffs, objName, "MaxNumberOfChildren");
  }
  
  private static void SetMaxNumberOfChildren(DXDrawDgms.VariableList openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDrawDgms.MaxNumberOfChildren,System.Int32>(openXmlElement, value);
  }
  
  private static Int32? GetPreferredNumberOfChildren(DXDrawDgms.VariableList openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXDrawDgms.PreferredNumberOfChildren>()?.Val);
  }
  
  private static bool CmpPreferredNumberOfChildren(DXDrawDgms.VariableList openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXDrawDgms.PreferredNumberOfChildren>()?.Val, value, diffs, objName, "PreferredNumberOfChildren");
  }
  
  private static void SetPreferredNumberOfChildren(DXDrawDgms.VariableList openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXDrawDgms.PreferredNumberOfChildren,System.Int32>(openXmlElement, value);
  }
  
  private static Boolean? GetBulletEnabled(DXDrawDgms.VariableList openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawDgms.BulletEnabled>() != null;
  }
  
  private static bool CmpBulletEnabled(DXDrawDgms.VariableList openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXDrawDgms.BulletEnabled>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXDrawDgms.BulletEnabled", val, value);
    return false;
  }
  
  private static void SetBulletEnabled(DXDrawDgms.VariableList openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.BulletEnabled>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXDrawDgms.BulletEnabled();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsDgms.DirectionKind? GetDirection(DXDrawDgms.VariableList openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDrawsDgms.DirectionKind>(openXmlElement.GetFirstChild<DXDrawDgms.Direction>()?.Val?.Value);
  }
  
  private static bool CmpDirection(DXDrawDgms.VariableList openXmlElement, DMDrawsDgms.DirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDrawsDgms.DirectionKind>(openXmlElement.GetFirstChild<DXDrawDgms.Direction>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetDirection(DXDrawDgms.VariableList openXmlElement, DMDrawsDgms.DirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Direction>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDrawsDgms.DirectionKind>(itemElement, (DMDrawsDgms.DirectionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawDgms.Direction, DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDrawsDgms.DirectionKind>((DMDrawsDgms.DirectionKind)value));
  }
  
  private static DMDrawsDgms.HierarchyBranchStyleKind? GetHierarchyBranch(DXDrawDgms.VariableList openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDrawsDgms.HierarchyBranchStyleKind>(openXmlElement.GetFirstChild<DXDrawDgms.HierarchyBranch>()?.Val?.Value);
  }
  
  private static bool CmpHierarchyBranch(DXDrawDgms.VariableList openXmlElement, DMDrawsDgms.HierarchyBranchStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDrawsDgms.HierarchyBranchStyleKind>(openXmlElement.GetFirstChild<DXDrawDgms.HierarchyBranch>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetHierarchyBranch(DXDrawDgms.VariableList openXmlElement, DMDrawsDgms.HierarchyBranchStyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.HierarchyBranch>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDrawsDgms.HierarchyBranchStyleKind>(itemElement, (DMDrawsDgms.HierarchyBranchStyleKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawDgms.HierarchyBranch, DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDrawsDgms.HierarchyBranchStyleKind>((DMDrawsDgms.HierarchyBranchStyleKind)value));
  }
  
  private static DMDrawsDgms.AnimateOneByOneKind? GetAnimateOneByOne(DXDrawDgms.VariableList openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDrawsDgms.AnimateOneByOneKind>(openXmlElement.GetFirstChild<DXDrawDgms.AnimateOneByOne>()?.Val?.Value);
  }
  
  private static bool CmpAnimateOneByOne(DXDrawDgms.VariableList openXmlElement, DMDrawsDgms.AnimateOneByOneKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDrawsDgms.AnimateOneByOneKind>(openXmlElement.GetFirstChild<DXDrawDgms.AnimateOneByOne>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetAnimateOneByOne(DXDrawDgms.VariableList openXmlElement, DMDrawsDgms.AnimateOneByOneKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.AnimateOneByOne>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDrawsDgms.AnimateOneByOneKind>(itemElement, (DMDrawsDgms.AnimateOneByOneKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawDgms.AnimateOneByOne, DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDrawsDgms.AnimateOneByOneKind>((DMDrawsDgms.AnimateOneByOneKind)value));
  }
  
  private static DMDrawsDgms.AnimationLevelStringKind? GetAnimationLevel(DXDrawDgms.VariableList openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDrawsDgms.AnimationLevelStringKind>(openXmlElement.GetFirstChild<DXDrawDgms.AnimationLevel>()?.Val?.Value);
  }
  
  private static bool CmpAnimationLevel(DXDrawDgms.VariableList openXmlElement, DMDrawsDgms.AnimationLevelStringKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDrawsDgms.AnimationLevelStringKind>(openXmlElement.GetFirstChild<DXDrawDgms.AnimationLevel>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetAnimationLevel(DXDrawDgms.VariableList openXmlElement, DMDrawsDgms.AnimationLevelStringKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.AnimationLevel>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDrawsDgms.AnimationLevelStringKind>(itemElement, (DMDrawsDgms.AnimationLevelStringKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawDgms.AnimationLevel, DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDrawsDgms.AnimationLevelStringKind>((DMDrawsDgms.AnimationLevelStringKind)value));
  }
  
  private static DMDrawsDgms.ResizeHandlesStringKind? GetResizeHandles(DXDrawDgms.VariableList openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDrawsDgms.ResizeHandlesStringKind>(openXmlElement.GetFirstChild<DXDrawDgms.ResizeHandles>()?.Val?.Value);
  }
  
  private static bool CmpResizeHandles(DXDrawDgms.VariableList openXmlElement, DMDrawsDgms.ResizeHandlesStringKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDrawsDgms.ResizeHandlesStringKind>(openXmlElement.GetFirstChild<DXDrawDgms.ResizeHandles>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetResizeHandles(DXDrawDgms.VariableList openXmlElement, DMDrawsDgms.ResizeHandlesStringKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ResizeHandles>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDrawsDgms.ResizeHandlesStringKind>(itemElement, (DMDrawsDgms.ResizeHandlesStringKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDrawDgms.ResizeHandles, DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDrawsDgms.ResizeHandlesStringKind>((DMDrawsDgms.ResizeHandlesStringKind)value));
  }
  
  public static DocumentModel.Drawings.Diagrams.VariableList? CreateModelElement(DXDrawDgms.VariableList? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawDgms.VariableList? openXmlElement, DMDrawsDgms.VariableList? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.VariableList value)
    where OpenXmlElementType: DXDrawDgms.VariableList, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawDgms.VariableList openXmlElement, DMDrawsDgms.VariableList value)
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
