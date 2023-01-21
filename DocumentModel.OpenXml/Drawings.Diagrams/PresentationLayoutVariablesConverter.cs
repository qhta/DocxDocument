namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Presentation Layout Variables.
/// </summary>
public static class PresentationLayoutVariablesConverter
{
  private static Boolean? GetOrganizationChart(DXDrawDgms.PresentationLayoutVariables openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.OrganizationChart>();
    return itemElement != null;
  }
  
  private static void SetOrganizationChart(DXDrawDgms.PresentationLayoutVariables openXmlElement, Boolean? value)
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
  
  private static Int32? GetMaxNumberOfChildren(DXDrawDgms.PresentationLayoutVariables openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.MaxNumberOfChildren>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMaxNumberOfChildren(DXDrawDgms.PresentationLayoutVariables openXmlElement, Int32? value)
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
  
  private static Int32? GetPreferredNumberOfChildren(DXDrawDgms.PresentationLayoutVariables openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawDgms.PreferredNumberOfChildren>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPreferredNumberOfChildren(DXDrawDgms.PresentationLayoutVariables openXmlElement, Int32? value)
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
  
  private static Boolean? GetBulletEnabled(DXDrawDgms.PresentationLayoutVariables openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.BulletEnabled>();
    return itemElement != null;
  }
  
  private static void SetBulletEnabled(DXDrawDgms.PresentationLayoutVariables openXmlElement, Boolean? value)
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
  
  private static DMDrawsDgms.DirectionKind? GetDirection(DXDrawDgms.PresentationLayoutVariables openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.Direction>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDrawsDgms.DirectionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetDirection(DXDrawDgms.PresentationLayoutVariables openXmlElement, DMDrawsDgms.DirectionKind? value)
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
  
  private static DMDrawsDgms.HierarchyBranchStyleKind? GetHierarchyBranch(DXDrawDgms.PresentationLayoutVariables openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.HierarchyBranch>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDrawsDgms.HierarchyBranchStyleKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHierarchyBranch(DXDrawDgms.PresentationLayoutVariables openXmlElement, DMDrawsDgms.HierarchyBranchStyleKind? value)
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
  
  private static DMDrawsDgms.AnimateOneByOneKind? GetAnimateOneByOne(DXDrawDgms.PresentationLayoutVariables openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.AnimateOneByOne>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDrawsDgms.AnimateOneByOneKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetAnimateOneByOne(DXDrawDgms.PresentationLayoutVariables openXmlElement, DMDrawsDgms.AnimateOneByOneKind? value)
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
  
  private static DMDrawsDgms.AnimationLevelStringKind? GetAnimationLevel(DXDrawDgms.PresentationLayoutVariables openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.AnimationLevel>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDrawsDgms.AnimationLevelStringKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetAnimationLevel(DXDrawDgms.PresentationLayoutVariables openXmlElement, DMDrawsDgms.AnimationLevelStringKind? value)
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
  
  private static DMDrawsDgms.ResizeHandlesStringKind? GetResizeHandles(DXDrawDgms.PresentationLayoutVariables openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawDgms.ResizeHandles>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDrawsDgms.ResizeHandlesStringKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetResizeHandles(DXDrawDgms.PresentationLayoutVariables openXmlElement, DMDrawsDgms.ResizeHandlesStringKind? value)
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
  
  public static DMDrawsDgms.PresentationLayoutVariables? CreateModelElement(DXDrawDgms.PresentationLayoutVariables? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.PresentationLayoutVariables();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.PresentationLayoutVariables? value)
    where OpenXmlElementType: DXDrawDgms.PresentationLayoutVariables, new()
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
