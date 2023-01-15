using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using LayoutVariablePropertySetType = DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Defines the LayoutVariablePropertySetType Class.
/// </summary>
public static class LayoutVariablePropertySetTypeConverter
{
  /// <summary>
  ///   Show Organization Chart User Interface.
  /// </summary>
  public static Boolean? GetOrganizationChart(LayoutVariablePropertySetType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<OrganizationChart>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetOrganizationChart(LayoutVariablePropertySetType? openXmlElement, Boolean? value)
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

  /// <summary>
  ///   Maximum Children.
  /// </summary>
  public static Int32? GetMaxNumberOfChildren(LayoutVariablePropertySetType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MaxNumberOfChildren>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMaxNumberOfChildren(LayoutVariablePropertySetType? openXmlElement, Int32? value)
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

  /// <summary>
  ///   Preferred Number of Children.
  /// </summary>
  public static Int32? GetPreferredNumberOfChildren(LayoutVariablePropertySetType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PreferredNumberOfChildren>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPreferredNumberOfChildren(LayoutVariablePropertySetType? openXmlElement, Int32? value)
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

  /// <summary>
  ///   Show Insert Bullet.
  /// </summary>
  public static Boolean? GetBulletEnabled(LayoutVariablePropertySetType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BulletEnabled>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetBulletEnabled(LayoutVariablePropertySetType? openXmlElement, Boolean? value)
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

  /// <summary>
  ///   Diagram Direction.
  /// </summary>
  public static DirectionKind? GetDirection(LayoutVariablePropertySetType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Direction>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DirectionValues, DirectionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetDirection(LayoutVariablePropertySetType? openXmlElement, DirectionKind? value)
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

  /// <summary>
  ///   Organization Chart Branch Style.
  /// </summary>
  public static HierarchyBranchStyleKind? GetHierarchyBranch(LayoutVariablePropertySetType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<HierarchyBranch>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<HierarchyBranchStyleValues, HierarchyBranchStyleKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetHierarchyBranch(LayoutVariablePropertySetType? openXmlElement, HierarchyBranchStyleKind? value)
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

  /// <summary>
  ///   One by One Animation String.
  /// </summary>
  public static AnimateOneByOneKind? GetAnimateOneByOne(LayoutVariablePropertySetType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AnimateOneByOne>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<AnimateOneByOneValues, AnimateOneByOneKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetAnimateOneByOne(LayoutVariablePropertySetType? openXmlElement, AnimateOneByOneKind? value)
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

  /// <summary>
  ///   Level Animation.
  /// </summary>
  public static AnimationLevelStringKind? GetAnimationLevel(LayoutVariablePropertySetType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AnimationLevel>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<AnimationLevelStringValues, AnimationLevelStringKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetAnimationLevel(LayoutVariablePropertySetType? openXmlElement, AnimationLevelStringKind? value)
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

  /// <summary>
  ///   Shape Resize Style.
  /// </summary>
  public static ResizeHandlesStringKind? GetResizeHandles(LayoutVariablePropertySetType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ResizeHandles>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<ResizeHandlesStringValues, ResizeHandlesStringKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetResizeHandles(LayoutVariablePropertySetType? openXmlElement, ResizeHandlesStringKind? value)
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

  public static DocumentModel.Drawings.Diagrams.LayoutVariablePropertySetType? CreateModelElement(LayoutVariablePropertySetType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.LayoutVariablePropertySetType();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.LayoutVariablePropertySetType? value)
    where OpenXmlElementType : LayoutVariablePropertySetType, new()
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