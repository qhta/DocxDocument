namespace DocumentModel.Drawings;

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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart>();
        return (Boolean?)openXmlElement?.Val?.Value;
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
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Diagrams.OrganizationChart{ Val = (System.Boolean?)value };
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
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Diagrams.MaxNumberOfChildren{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Preferred Number of Children.
  /// </summary>
  public virtual Int32? PreferredNumberOfChildren
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Diagrams.PreferredNumberOfChildren{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
          }
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled>();
        return (Boolean?)openXmlElement?.Val?.Value;
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
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Diagrams.BulletEnabled{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Diagram Direction.
  /// </summary>
  public virtual DirectionKind? Direction
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Direction>();
        return (DirectionKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Direction>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Diagrams.Direction{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Organization Chart Branch Style.
  /// </summary>
  public virtual HierarchyBranchStyleKind? HierarchyBranch
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch>();
        return (HierarchyBranchStyleKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// One by One Animation String.
  /// </summary>
  public virtual AnimateOneByOneKind? AnimateOneByOne
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne>();
        return (AnimateOneByOneKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Level Animation.
  /// </summary>
  public virtual AnimationLevelStringKind? AnimationLevel
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel>();
        return (AnimationLevelStringKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Shape Resize Style.
  /// </summary>
  public virtual ResizeHandlesStringKind? ResizeHandles
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles>();
        return (ResizeHandlesStringKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
