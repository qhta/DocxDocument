namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LayoutVariablePropertySetType Class.
/// </summary>
public class LayoutVariablePropertySetTypeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutVariablePropertySetType>, LayoutVariablePropertySetType
{
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Direction>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Diagrams.Direction{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranch{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOne{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevel{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandles{ Val = (DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
