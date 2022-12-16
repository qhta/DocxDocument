namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the LayoutVariablePropertySetType Class.
/// </summary>
public class LayoutVariablePropertySetTypeImpl: ModelElementImpl, LayoutVariablePropertySetType
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LayoutVariablePropertySetTypeImpl(): base() {}
  
  public LayoutVariablePropertySetTypeImpl(DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Show Organization Chart User Interface.
  /// </summary>
  public virtual Boolean? OrganizationChart
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Maximum Children.
  /// </summary>
  public virtual Int32? MaxNumberOfChildren
  {
    get => (System.Int32?)OpenXmlElement?.MaxNumberOfChildren?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.MaxNumberOfChildren != null)
        {
          if (value is not null)
            OpenXmlElement.MaxNumberOfChildren.Val = (System.Int32?)value;
          else
            OpenXmlElement.MaxNumberOfChildren = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.MaxNumberOfChildren = new DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Preferred Number of Children.
  /// </summary>
  public virtual Int32? PreferredNumberOfChildren
  {
    get => (System.Int32?)OpenXmlElement?.PreferredNumberOfChildren?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PreferredNumberOfChildren != null)
        {
          if (value is not null)
            OpenXmlElement.PreferredNumberOfChildren.Val = (System.Int32?)value;
          else
            OpenXmlElement.PreferredNumberOfChildren = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PreferredNumberOfChildren = new DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren{ Val = (System.Int32?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Show Insert Bullet.
  /// </summary>
  public virtual Boolean? BulletEnabled
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled>();
        return item != null;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled>();
        if (item != null)
        {
          if (value == false)
            item.Remove();
        }
        else
        {
          if (value == true)
          {
            item = new DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled();
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Diagram Direction.
  /// </summary>
  public virtual DocumentModel.Drawings.Diagrams.DirectionKind? Direction
  {
    get => (DocumentModel.Drawings.Diagrams.DirectionKind?)OpenXmlElement?.Direction?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Direction != null)
        {
          if (value is not null)
            OpenXmlElement.Direction.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues?)value;
          else
            OpenXmlElement.Direction = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Direction = new DocumentFormat.OpenXml.Drawing.Diagrams.Direction{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Organization Chart Branch Style.
  /// </summary>
  public virtual DocumentModel.Drawings.Diagrams.HierarchyBranchStyleKind? HierarchyBranch
  {
    get => (DocumentModel.Drawings.Diagrams.HierarchyBranchStyleKind?)OpenXmlElement?.HierarchyBranch?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HierarchyBranch != null)
        {
          if (value is not null)
            OpenXmlElement.HierarchyBranch.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues?)value;
          else
            OpenXmlElement.HierarchyBranch = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HierarchyBranch = new DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// One by One Animation String.
  /// </summary>
  public virtual DocumentModel.Drawings.Diagrams.AnimateOneByOneKind? AnimateOneByOne
  {
    get => (DocumentModel.Drawings.Diagrams.AnimateOneByOneKind?)OpenXmlElement?.AnimateOneByOne?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AnimateOneByOne != null)
        {
          if (value is not null)
            OpenXmlElement.AnimateOneByOne.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues?)value;
          else
            OpenXmlElement.AnimateOneByOne = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AnimateOneByOne = new DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Level Animation.
  /// </summary>
  public virtual DocumentModel.Drawings.Diagrams.AnimationLevelStringKind? AnimationLevel
  {
    get => (DocumentModel.Drawings.Diagrams.AnimationLevelStringKind?)OpenXmlElement?.AnimationLevel?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.AnimationLevel != null)
        {
          if (value is not null)
            OpenXmlElement.AnimationLevel.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues?)value;
          else
            OpenXmlElement.AnimationLevel = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.AnimationLevel = new DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Shape Resize Style.
  /// </summary>
  public virtual DocumentModel.Drawings.Diagrams.ResizeHandlesStringKind? ResizeHandles
  {
    get => (DocumentModel.Drawings.Diagrams.ResizeHandlesStringKind?)OpenXmlElement?.ResizeHandles?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.ResizeHandles != null)
        {
          if (value is not null)
            OpenXmlElement.ResizeHandles.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues?)value;
          else
            OpenXmlElement.ResizeHandles = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.ResizeHandles = new DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues?)value };
        }
      }
    }
  }
  
}
