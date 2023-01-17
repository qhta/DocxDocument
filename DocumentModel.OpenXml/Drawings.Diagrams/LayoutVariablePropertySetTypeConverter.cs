namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the LayoutVariablePropertySetType Class.
/// </summary>
public static class LayoutVariablePropertySetTypeConverter
{
  /// <summary>
  /// Show Organization Chart User Interface.
  /// </summary>
  private static Boolean? GetOrganizationChart(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart>();
    return itemElement != null;
  }
  
  private static void SetOrganizationChart(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Maximum Children.
  /// </summary>
  private static Int32? GetMaxNumberOfChildren(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetMaxNumberOfChildren(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Preferred Number of Children.
  /// </summary>
  private static Int32? GetPreferredNumberOfChildren(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPreferredNumberOfChildren(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement, Int32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Show Insert Bullet.
  /// </summary>
  private static Boolean? GetBulletEnabled(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled>();
    return itemElement != null;
  }
  
  private static void SetBulletEnabled(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Diagram Direction.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.DirectionKind? GetDirection(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Direction>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DocumentModel.Drawings.Diagrams.DirectionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetDirection(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement, DocumentModel.Drawings.Diagrams.DirectionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Direction>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Direction, DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DocumentModel.Drawings.Diagrams.DirectionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Organization Chart Branch Style.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.HierarchyBranchStyleKind? GetHierarchyBranch(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DocumentModel.Drawings.Diagrams.HierarchyBranchStyleKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetHierarchyBranch(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement, DocumentModel.Drawings.Diagrams.HierarchyBranchStyleKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch, DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DocumentModel.Drawings.Diagrams.HierarchyBranchStyleKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// One by One Animation String.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.AnimateOneByOneKind? GetAnimateOneByOne(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DocumentModel.Drawings.Diagrams.AnimateOneByOneKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetAnimateOneByOne(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement, DocumentModel.Drawings.Diagrams.AnimateOneByOneKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne, DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DocumentModel.Drawings.Diagrams.AnimateOneByOneKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Level Animation.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.AnimationLevelStringKind? GetAnimationLevel(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DocumentModel.Drawings.Diagrams.AnimationLevelStringKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetAnimationLevel(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement, DocumentModel.Drawings.Diagrams.AnimationLevelStringKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel, DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DocumentModel.Drawings.Diagrams.AnimationLevelStringKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shape Resize Style.
  /// </summary>
  private static DocumentModel.Drawings.Diagrams.ResizeHandlesStringKind? GetResizeHandles(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DocumentModel.Drawings.Diagrams.ResizeHandlesStringKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetResizeHandles(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement, DocumentModel.Drawings.Diagrams.ResizeHandlesStringKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles, DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DocumentModel.Drawings.Diagrams.ResizeHandlesStringKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Diagrams.LayoutVariablePropertySetType? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType, new()
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
