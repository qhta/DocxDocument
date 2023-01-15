using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using VariableList = DocumentFormat.OpenXml.Drawing.Diagrams.VariableList;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Variable List.
/// </summary>
public static class VariableListConverter
{
  public static Boolean? GetOrganizationChart(VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OrganizationChart>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetOrganizationChart(VariableList? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<OrganizationChart>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new OrganizationChart();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetMaxNumberOfChildren(VariableList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MaxNumberOfChildren>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMaxNumberOfChildren(VariableList? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MaxNumberOfChildren>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new MaxNumberOfChildren { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetPreferredNumberOfChildren(VariableList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PreferredNumberOfChildren>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPreferredNumberOfChildren(VariableList? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PreferredNumberOfChildren>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PreferredNumberOfChildren { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Boolean? GetBulletEnabled(VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BulletEnabled>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBulletEnabled(VariableList? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<BulletEnabled>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new BulletEnabled();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DirectionKind? GetDirection(VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Direction>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DirectionValues, DirectionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetDirection(VariableList? openXmlElement, DirectionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Direction>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Direction, DirectionValues, DirectionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static HierarchyBranchStyleKind? GetHierarchyBranch(VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HierarchyBranch>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<HierarchyBranchStyleValues, HierarchyBranchStyleKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetHierarchyBranch(VariableList? openXmlElement, HierarchyBranchStyleKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HierarchyBranch>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<HierarchyBranch, HierarchyBranchStyleValues, HierarchyBranchStyleKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AnimateOneByOneKind? GetAnimateOneByOne(VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AnimateOneByOne>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<AnimateOneByOneValues, AnimateOneByOneKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetAnimateOneByOne(VariableList? openXmlElement, AnimateOneByOneKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AnimateOneByOne>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<AnimateOneByOne, AnimateOneByOneValues, AnimateOneByOneKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AnimationLevelStringKind? GetAnimationLevel(VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AnimationLevel>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<AnimationLevelStringValues, AnimationLevelStringKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetAnimationLevel(VariableList? openXmlElement, AnimationLevelStringKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AnimationLevel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<AnimationLevel, AnimationLevelStringValues, AnimationLevelStringKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ResizeHandlesStringKind? GetResizeHandles(VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ResizeHandles>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<ResizeHandlesStringValues, ResizeHandlesStringKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetResizeHandles(VariableList? openXmlElement, ResizeHandlesStringKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ResizeHandles>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ResizeHandles, ResizeHandlesStringValues, ResizeHandlesStringKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.VariableList? CreateModelElement(VariableList? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.VariableList? value)
    where OpenXmlElementType : VariableList, new()
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