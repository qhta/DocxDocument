namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Variable List.
/// </summary>
public static class VariableListConverter
{
  public static Boolean? GetOrganizationChart(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetOrganizationChart(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Int32? GetMaxNumberOfChildren(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetMaxNumberOfChildren(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Int32? GetPreferredNumberOfChildren(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetPreferredNumberOfChildren(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Boolean? GetBulletEnabled(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetBulletEnabled(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.DirectionKind? GetDirection(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Direction>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DocumentModel.Drawings.Diagrams.DirectionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDirection(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement, DocumentModel.Drawings.Diagrams.DirectionKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.HierarchyBranchStyleKind? GetHierarchyBranch(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DocumentModel.Drawings.Diagrams.HierarchyBranchStyleKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetHierarchyBranch(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement, DocumentModel.Drawings.Diagrams.HierarchyBranchStyleKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.AnimateOneByOneKind? GetAnimateOneByOne(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DocumentModel.Drawings.Diagrams.AnimateOneByOneKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetAnimateOneByOne(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement, DocumentModel.Drawings.Diagrams.AnimateOneByOneKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.AnimationLevelStringKind? GetAnimationLevel(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DocumentModel.Drawings.Diagrams.AnimationLevelStringKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetAnimationLevel(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement, DocumentModel.Drawings.Diagrams.AnimationLevelStringKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.ResizeHandlesStringKind? GetResizeHandles(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DocumentModel.Drawings.Diagrams.ResizeHandlesStringKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetResizeHandles(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement, DocumentModel.Drawings.Diagrams.ResizeHandlesStringKind? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Diagrams.VariableList? CreateModelElement(DocumentFormat.OpenXml.Drawing.Diagrams.VariableList? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Diagrams.VariableList, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
