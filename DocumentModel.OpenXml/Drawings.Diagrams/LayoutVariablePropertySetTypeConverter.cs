namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the LayoutVariablePropertySetType Class.
/// </summary>
public static class LayoutVariablePropertySetTypeConverter
{
  /// <summary>
  /// Show Organization Chart User Interface.
  /// </summary>
  private static Boolean? GetOrganizationChart(DXDrawDgms.LayoutVariablePropertySetType openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawDgms.OrganizationChart>() != null;
  }
  
  private static bool CmpOrganizationChart(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawDgms.OrganizationChart>() != null == value;
  }
  
  private static void SetOrganizationChart(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// Maximum Children.
  /// </summary>
  private static Int32? GetMaxNumberOfChildren(DXDrawDgms.LayoutVariablePropertySetType openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawDgms.MaxNumberOfChildren>()?.Val?.Value;
  }
  
  private static bool CmpMaxNumberOfChildren(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawDgms.MaxNumberOfChildren>()?.Val?.Value == value;
  }
  
  private static void SetMaxNumberOfChildren(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.MaxNumberOfChildren>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawDgms.MaxNumberOfChildren{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Preferred Number of Children.
  /// </summary>
  private static Int32? GetPreferredNumberOfChildren(DXDrawDgms.LayoutVariablePropertySetType openXmlElement)
  {
    return openXmlElement?.GetFirstChild<DXDrawDgms.PreferredNumberOfChildren>()?.Val?.Value;
  }
  
  private static bool CmpPreferredNumberOfChildren(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetFirstChild<DXDrawDgms.PreferredNumberOfChildren>()?.Val?.Value == value;
  }
  
  private static void SetPreferredNumberOfChildren(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.PreferredNumberOfChildren>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawDgms.PreferredNumberOfChildren{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Show Insert Bullet.
  /// </summary>
  private static Boolean? GetBulletEnabled(DXDrawDgms.LayoutVariablePropertySetType openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXDrawDgms.BulletEnabled>() != null;
  }
  
  private static bool CmpBulletEnabled(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.GetFirstChild<DXDrawDgms.BulletEnabled>() != null == value;
  }
  
  private static void SetBulletEnabled(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, Boolean? value)
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
  
  /// <summary>
  /// Diagram Direction.
  /// </summary>
  private static DMDrawsDgms.DirectionKind? GetDirection(DXDrawDgms.LayoutVariablePropertySetType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDrawsDgms.DirectionKind>(openXmlElement.GetFirstChild<DXDrawDgms.Direction>()?.Val?.Value);
  }
  
  private static bool CmpDirection(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, DMDrawsDgms.DirectionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDrawsDgms.DirectionKind>(openXmlElement.GetFirstChild<DXDrawDgms.Direction>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDirection(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, DMDrawsDgms.DirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Direction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawDgms.Direction, DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDrawsDgms.DirectionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Organization Chart Branch Style.
  /// </summary>
  private static DMDrawsDgms.HierarchyBranchStyleKind? GetHierarchyBranch(DXDrawDgms.LayoutVariablePropertySetType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDrawsDgms.HierarchyBranchStyleKind>(openXmlElement.GetFirstChild<DXDrawDgms.HierarchyBranch>()?.Val?.Value);
  }
  
  private static bool CmpHierarchyBranch(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, DMDrawsDgms.HierarchyBranchStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDrawsDgms.HierarchyBranchStyleKind>(openXmlElement.GetFirstChild<DXDrawDgms.HierarchyBranch>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHierarchyBranch(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, DMDrawsDgms.HierarchyBranchStyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.HierarchyBranch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawDgms.HierarchyBranch, DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDrawsDgms.HierarchyBranchStyleKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// One by One Animation String.
  /// </summary>
  private static DMDrawsDgms.AnimateOneByOneKind? GetAnimateOneByOne(DXDrawDgms.LayoutVariablePropertySetType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDrawsDgms.AnimateOneByOneKind>(openXmlElement.GetFirstChild<DXDrawDgms.AnimateOneByOne>()?.Val?.Value);
  }
  
  private static bool CmpAnimateOneByOne(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, DMDrawsDgms.AnimateOneByOneKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDrawsDgms.AnimateOneByOneKind>(openXmlElement.GetFirstChild<DXDrawDgms.AnimateOneByOne>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAnimateOneByOne(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, DMDrawsDgms.AnimateOneByOneKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.AnimateOneByOne>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawDgms.AnimateOneByOne, DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDrawsDgms.AnimateOneByOneKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Level Animation.
  /// </summary>
  private static DMDrawsDgms.AnimationLevelStringKind? GetAnimationLevel(DXDrawDgms.LayoutVariablePropertySetType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDrawsDgms.AnimationLevelStringKind>(openXmlElement.GetFirstChild<DXDrawDgms.AnimationLevel>()?.Val?.Value);
  }
  
  private static bool CmpAnimationLevel(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, DMDrawsDgms.AnimationLevelStringKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDrawsDgms.AnimationLevelStringKind>(openXmlElement.GetFirstChild<DXDrawDgms.AnimationLevel>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAnimationLevel(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, DMDrawsDgms.AnimationLevelStringKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.AnimationLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawDgms.AnimationLevel, DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDrawsDgms.AnimationLevelStringKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Resize Style.
  /// </summary>
  private static DMDrawsDgms.ResizeHandlesStringKind? GetResizeHandles(DXDrawDgms.LayoutVariablePropertySetType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDrawsDgms.ResizeHandlesStringKind>(openXmlElement.GetFirstChild<DXDrawDgms.ResizeHandles>()?.Val?.Value);
  }
  
  private static bool CmpResizeHandles(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, DMDrawsDgms.ResizeHandlesStringKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDrawsDgms.ResizeHandlesStringKind>(openXmlElement.GetFirstChild<DXDrawDgms.ResizeHandles>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetResizeHandles(DXDrawDgms.LayoutVariablePropertySetType openXmlElement, DMDrawsDgms.ResizeHandlesStringKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ResizeHandles>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXDrawDgms.ResizeHandles, DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDrawsDgms.ResizeHandlesStringKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsDgms.LayoutVariablePropertySetType? CreateModelElement(DXDrawDgms.LayoutVariablePropertySetType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.LayoutVariablePropertySetType();
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
  
  public static bool CompareModelElement(DXDrawDgms.LayoutVariablePropertySetType? openXmlElement, DMDrawsDgms.LayoutVariablePropertySetType? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.LayoutVariablePropertySetType? value)
    where OpenXmlElementType: DXDrawDgms.LayoutVariablePropertySetType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOrganizationChart(openXmlElement, value?.OrganizationChart);
      SetMaxNumberOfChildren(openXmlElement, value?.MaxNumberOfChildren);
      SetPreferredNumberOfChildren(openXmlElement, value?.PreferredNumberOfChildren);
      SetBulletEnabled(openXmlElement, value?.BulletEnabled);
      SetDirection(openXmlElement, value?.Direction);
      SetHierarchyBranch(openXmlElement, value?.HierarchyBranch);
      SetAnimateOneByOne(openXmlElement, value?.AnimateOneByOne);
      SetAnimationLevel(openXmlElement, value?.AnimationLevel);
      SetResizeHandles(openXmlElement, value?.ResizeHandles);
      return openXmlElement;
    }
    return default;
  }
}
